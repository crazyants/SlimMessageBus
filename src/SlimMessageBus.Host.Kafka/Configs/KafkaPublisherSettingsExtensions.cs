﻿using System;
using SlimMessageBus.Host.Config;

namespace SlimMessageBus.Host.Kafka
{
    public static class KafkaPublisherSettingsExtensions
    {
        internal const string KeyProviderKey = "Kafka_KeyProvider";
        internal const string PartitionProviderKey = "Kafka_PartitionProvider";

        public static Func<object, string, byte[]> GetKeyProvider(this PublisherSettings ps)
        {
            return ps.GetOrDefault<Func<object, string, byte[]>>(KeyProviderKey, null);
        }

        public static Func<object, string, int> GetPartitionProvider(this PublisherSettings ps)
        {
            return ps.GetOrDefault<Func<object, string, int>>(PartitionProviderKey, null);
        }
    }
}