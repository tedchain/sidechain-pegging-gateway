// Copyright (c) 2010-2018 The Bitcoin developers
// Original code was distributed under the MIT software license.
// Copyright (c) 2014-2018 TEDLab Sciences Ltd
// Tedchain code distributed under the GPLv3 license, see COPYING file.

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace Tedchain.BitcoinGateway
{
    public class PegGateway
    {
        private readonly ILogger logger;

        public PegGateway(BitcoinClient bitcoinClient, TedchainClient tedChainClient, ILogger logger)
        {
            this.BitcoinClient = bitcoinClient;
            this.TedchainClient = tedChainClient;
            this.logger = logger;
        }

        public BitcoinClient BitcoinClient { get; }

        public TedchainClient TedchainClient { get; }

        public async Task BitcoinToTedChain()
        {
            while (true)
            {
                try
                {
                    IList<InboundTransaction> transactions = await this.BitcoinClient.GetUnspentOutputs();

                    foreach (InboundTransaction transaction in transactions)
                    {
                        try
                        {
                            await TedchainClient.AddAsset(transaction);
                            await BitcoinClient.MoveToStorage(transaction);
                        }
                        catch (Exception exception)
                        {
                            this.logger.LogError($"An exception occurred: {exception.ToString()}");
                        }
                    }
                }
                catch (Exception exception)
                {
                    this.logger.LogError($"An exception occurred: {exception.ToString()}");
                }

                await Task.Delay(TimeSpan.FromSeconds(5));
            }
        }

        public async Task TedchainToBitcoin()
        {
            while (true)
            {
                try
                {
                    IList<OutboundTransaction> transactions = await this.TedchainClient.GetUnprocessedTransactions();

                    if (transactions.Count > 0)
                    {
                        ByteString withdrawalTransaction = await this.BitcoinClient.IssueWithdrawal(transactions);

                        await this.TedchainClient.MoveToRedemption(transactions, withdrawalTransaction);
                        await this.BitcoinClient.SubmitTransaction(withdrawalTransaction);
                    }
                }
                catch (Exception exception)
                {
                    this.logger.LogError($"An exception occurred: {exception.ToString()}");
                }

                await Task.Delay(TimeSpan.FromSeconds(5));
            }
        }
    }
}
