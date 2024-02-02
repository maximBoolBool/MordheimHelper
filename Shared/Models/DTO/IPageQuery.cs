namespace SharedEntities.Models.DTO;

public interface IPageQuery
{
    public int Skip { get; set; }
    
    public int Take { get; set; }
}