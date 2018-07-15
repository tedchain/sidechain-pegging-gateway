// Copyright (c) 2010-2018 The Bitcoin developers.
// Original code was distributed under the MIT software license.
// Copyright (c) 2014-2018 TEDLab Sciences Ltd
// Tedchain code distributed under the GPLv3 license, see COPYING file.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using NBitcoin;
using NBitcoin.DataEncoders;

namespace Tedchain.BitcoinGateway.Module
{
    public class Startup
    {
        private List<Task> workers = new List<Task>();

        public void ConfigureServices(IServiceCollection services)
        {
            // Setup logging
            services.BuildServiceProvider().GetService<ILoggerFactory>().AddConsole();
            services.AddTransient<ILogger>(serviceProvider => serviceProvider.GetService<ILoggerFactory>().CreateLogger("General"));

            // Setup configuration
            services.AddSingleton<IConfiguration>(_ =>
                new ConfigurationBuilder().SetBasePath(".").AddJsonFile("config.json").AddUserSecrets().Build());

            // Setup ASP.NET MVC
            services.AddMvcCore().AddViews();

            // CORS Headers
            services.AddCors();

            // Other
            services.AddInstance<PegGateway>(CreatePegGateway(services.BuildServiceProvider()));
        }

        private PegGateway CreatePegGateway(IServiceProvider serviceProvider)
        {
            IConfiguration config = serviceProvider.GetService<IConfiguration>();
            ILogger logger = serviceProvider.GetService<ILogger>();

            Key gatewayKey = Key.Parse(config["gateway_key"], Network.TestNet);
            Key storageKey = Key.Parse(config["storage_key"], Network.TestNet);

            BitcoinClient bitcoinClient = new BitcoinClient(new Uri(config["bitcoin_api_url"]), gatewayKey, storageKey, Network.TestNet, logger);
            logger.LogInformation($"Initializing OC-Bitcoin-Gateway with address {bitcoinClient.ReceivingAddress}");
            string gatewayAdminAddress = Encoders.Base58Check.EncodeData(new byte[] { 76 }.Concat(gatewayKey.PubKey.GetAddress(Network.Main).Hash.ToBytes()).ToArray());
            logger.LogInformation($"Tedchain Gateway address: {gatewayAdminAddress}");
            TedchainClient tedchain = new TedchainClient(gatewayKey, "btc", new Uri(config["tedchain_server"]), Network.TestNet);
            return new PegGateway(bitcoinClient, tedchain, logger);
        }

        public void Configure(IApplicationBuilder app, ILogger logger, IConfiguration config, PegGateway gateway)
        {
            app.UseCors(builder => builder.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin());

            app.UseIISPlatformHandler();

            // Add MVC to the request pipeline.
            app.UseMvc();

            this.workers.Add(gateway.TedchainToBitcoin());
            //this.workers.Add(gateway.BitcoinToTedChain());
        }
    }
}
