// Copyright (c) 2010-2018 The Bitcoin developers
// Original code was distributed under the MIT software license.
// Copyright (c) 2014-2018 TEDLab Sciences Ltd
// Tedchain code distributed under the GPLv3 license, see COPYING file.

namespace Tedchain.BitcoinGateway
{
    public class OutboundTransaction
    {
        public OutboundTransaction(ByteString recordKey, long amount, ByteString version, string target)
        {
            this.RecordKey = recordKey;
            this.Amount = amount;
            this.Version = version;
            this.Target = target;
        }

        public ByteString RecordKey { get; }

        public ByteString Version { get; }

        public long Amount { get; }

        public string Target { get; }
    }
}
