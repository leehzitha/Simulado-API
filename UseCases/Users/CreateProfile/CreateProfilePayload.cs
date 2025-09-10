using System.ComponentModel.DataAnnotations;

namespace simulado.UseCases.Users.CreateProfile;

public record CreateProfilePayload {
    [Required]
    public string Username;

    [Required]
    [EmailAddress]
    public string Email;

    [Required]
    [MinLength(8)]
    public string Password;
    public string Description;

}