namespace UesrServices.Models.Requests;

/// <summary>
///     Изменить существующую банду
/// </summary>
public class UpdateBandRequest
{
    /// <summary>
    ///  Id
    /// </summary>
    public long Id { get; set; }
    
    /// <summary>
    ///     Максимальная цена
    /// </summary>
    public int MaxCost { get; set; }
    
    /// <summary>
    ///     Название банды
    /// </summary>
    public string Name { get; set; }
}