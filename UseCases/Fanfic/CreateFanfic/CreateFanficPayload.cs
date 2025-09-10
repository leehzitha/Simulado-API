using System.ComponentModel.DataAnnotations;

namespace simulado.UseCases.Fanfic.CreateFanfic;

public record CreateFanficPayload{
    [Required]
    public int CreatorID;
    [Required]
    public string Title;
    public string Text;

};