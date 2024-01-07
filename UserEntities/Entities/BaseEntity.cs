using System.ComponentModel.DataAnnotations.Schema;

namespace UserEntities.Entities;

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
}