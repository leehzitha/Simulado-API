namespace simulado.UseCases.ReadList.CreateReadList;

public record CreateReadListPayload {
    [Required]
    public string Title;
}