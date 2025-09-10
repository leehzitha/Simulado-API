using System.ComponentModel.DataAnnotations;

namespace simulado.UseCases.ReadList.CreateReadList;

public record CreateReadListPayload {
    public required string Title;
}