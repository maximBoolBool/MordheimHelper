using KafkaServices.Impl;
using SharedEntities.Models.DTO.Response;
using UesrServices.KafkaServices.Configs;

namespace UesrServices.KafkaServices.Impl;

public class KafkaBandConsumer : BaseKafkaConsumer<BandDto>, IKafkaBandConsumer
{
    public KafkaBandConsumer(BandKafkaConsumerConfigs config) : base(config)
    { }
}