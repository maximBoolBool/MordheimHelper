﻿using KafkaServices.Impl;
using RuleServices.Kafka.Configs;
using SharedEntities.Models.DTO.Response;

namespace RuleServices.Kafka.Impl;

internal class KafkaUnitProducer : BaseKafkaProducer<UnitResponse>, IKafkaUnitProducer
{
    public KafkaUnitProducer(KafkaUnitProducerConfigs configs) : base(configs) { }
}