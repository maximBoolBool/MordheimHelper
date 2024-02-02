using System.Runtime.Serialization;

namespace SharedEntities;

/// <summary>
///     Тип модели
/// </summary>
public enum ModelType
{
    /// <summary>
    ///     Рядовой
    /// </summary>
    Common = 0,
    
    /// <summary>
    ///     Персонаж
    /// </summary>
    Character = 1,
    
    /// <summary>
    ///     Лидер отряда
    /// </summary>
    Leader = 2,
}