using System.ComponentModel.DataAnnotations.Schema;

namespace SharedEntities.Entities;

/// <summary>
///     Базовая сущность в бд
/// </summary>
public class BaseEntity
{
    /// <summary>
    ///     Id записи
    /// </summary>
    [Column("id")]
    public long Id { get; set; }
    
    /// <summary>
    ///     Статус активности
    /// </summary>
    [Column("is_active")]
    public bool IsActive { get; set; } = true;
}