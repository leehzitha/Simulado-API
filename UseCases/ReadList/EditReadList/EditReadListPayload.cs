namespace simulado.UseCases.ReadList.EditReadList;

public record EditReadListPayload
{
    public required int ReadListID { get; set; }
    
    public required int FanficID { get; set; }

    
}