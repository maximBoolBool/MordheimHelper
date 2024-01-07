using System.ComponentModel.DataAnnotations.Schema;

namespace UserEntities.Entities;

/// <summary>
///     Сущность пользователя
/// </summary>
[Table("users")]
public class UserEntity : BaseEntity
{
    /// <summary>
    ///     Логин
    /// </summary>
    [Column("login")]
    public string Login { get; set; }
    
    /// <summary>
    ///     Пароль
    /// </summary>
    [Column("password")]
    public string Password { get; set; }
    
    /// <summary>
    ///     Банды пользователя
    /// </summary>
    public List<BandEntity> Bands { get; set; }
}