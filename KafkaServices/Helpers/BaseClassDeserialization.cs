using System.Text;
using Confluent.Kafka;
using Newtonsoft.Json;

namespace KafkaServices.Helpers;

public class BaseClassDeserialization<TRequest> : IDeserializer<TRequest> where TRequest : class
{
    public TRequest Deserialize(ReadOnlySpan<byte> data, bool isNull, SerializationContext context)
    {
        var jsonString = Encoding.UTF8.GetString(data);
        return JsonConvert.DeserializeObject<TRequest>(jsonString)!;
    }
}