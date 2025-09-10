using System.ComponentModel.DataAnnotations;

namespace simulado.UseCases.Fanfics.CreateFanfic;

public record CreateFanficPayload{
    [Required]
    public int CreatorID;
    [Required]
    public string Title;
    public string Text;

};