using System.Text;
using Confluent.Kafka;
using Newtonsoft.Json;

namespace KafkaServices.Helpers;

public class BaseClassSerialization<TModel> : ISerializer<TModel>
{
    public byte[] Serialize(TModel data, SerializationContext context)
    {
        var jsonData = JsonConvert.SerializeObject(data);
        return Encoding.UTF8.GetBytes(jsonData);
    }
}