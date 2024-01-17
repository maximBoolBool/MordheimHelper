namespace SharedEntities.Models;

public class ResponseList<TResponse>
{
    public int Skip { get; set; }
    
    public int Take { get; set; }
    
    public List<TResponse> Collection { get; set; }
}