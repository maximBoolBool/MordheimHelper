namespace UserService.Configs;

/// <summary>
///     Ключи для конфигов UserService
/// </summary>
public static class UserServiceConfigKeys
{
    /// <summary>
    ///     Строка подключения Kafka
    /// </summary>
    public static string KAFKA_BOOTSTRAP { get; set; } = "kafka_bootstrap";

    /// <summary>
    ///     Группа потребителей user
    /// </summary>
    public static string USER_CONSUMER_GROUP_ID { get; set; } = "user_consumer_group_id";

    /// <summary>
    ///       Топик для получения ответов
    /// </summary>
    public static string USER_RESPONSE_TOPIC { get; set; } = "user_response_topic";

    /// <summary>
    ///     Топик для запросов
    /// </summary>
    public static string USER_REQUEST_TOPIC { get; set; } = "user_request_topic";
}