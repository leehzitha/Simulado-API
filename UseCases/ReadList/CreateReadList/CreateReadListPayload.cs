namespace simulado.UseCases.Fanfic.CreateReadList;

public record CreateReadListPayload {
    [Required]
    public string Title;
}