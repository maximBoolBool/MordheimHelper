namespace UserService.Configs;

public static class UserServiceConfigKeys
{
    public static string KAFKA_BOOTSTRAP { get; set; } = "kafka_bootstrap";

    public static string USER_CONSUMER_GROUP_ID { get; set; } = "user_consumer_group_id";

    public static string USER_RESPONSE_TOPIC { get; set; } = "user_response_topic";
}