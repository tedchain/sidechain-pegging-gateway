﻿// Copyright (c) 2010-2018 The Bitcoin developers
// Original code was distributed under the MIT software license.
// Copyright (c) 2014-2018 TEDLab Sciences Ltd
// Tedchain code distributed under the GPLv3 license, see COPYING file.

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Bitcoin.PaymentProtocol;
using Google.Protobuf;
using NBitcoin;

namespace Tedchain.BitcoinGateway
{
    public class PaymentRequestManager
    {
        private readonly ulong dustValue = 1000;
        private readonly bool isMainNet;
        private readonly BitcoinAddress destinationAddress;

        public PaymentRequestManager(bool isMainNet, string destinationAddress)
        {
            this.isMainNet = isMainNet;
            this.destinationAddress = BitcoinAddress.Create(destinationAddress);
        }

        public ByteString GetPaymentRequest(string finalAccount, ulong amount)
        {
            PaymentDetails paymentDetails = new PaymentDetails();
            paymentDetails.Network = isMainNet ? "main" : "test";
            paymentDetails.Time = GetTimestamp(DateTime.UtcNow);
            paymentDetails.Expires = GetTimestamp(DateTime.UtcNow.AddHours(1));
            paymentDetails.Memo = $"Funding Tedchain account {finalAccount}";

            Output paymentOutput = new Output();
            paymentOutput.Amount = amount;
            paymentOutput.Script = Google.Protobuf.ByteString.CopyFrom(NBitcoin.Script.CreateFromDestinationAddress(destinationAddress).ToBytes());

            Output dataOutput = new Output();
            dataOutput.Amount = dustValue;
            dataOutput.Script = Google.Protobuf.ByteString.CopyFrom(
                new[] { (byte)OpcodeType.OP_RETURN }.Concat(Op.GetPushOp(Encoding.UTF8.GetBytes("OG" + finalAccount)).ToBytes()).ToArray());

            paymentDetails.Outputs.Add(paymentOutput);
            paymentDetails.Outputs.Add(dataOutput);

            PaymentRequest request = new PaymentRequest();
            request.SerializedPaymentDetails = paymentDetails.ToByteString();
            request.PkiType = "none";

            return new ByteString(request.ToByteArray());
        }

        private static ulong GetTimestamp(DateTime date)
        {
            return (ulong)(date - new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc)).TotalSeconds;
        }
    }
}
