namespace simulado.UseCases.Fanfic.CreateProfile;

public record CreateProfilePayload {
    [Required]
    public string Username;

    [Required]
    [EmailAdress]
    public string Email;

    [Required]
    [MinLenght(8)]
    public string Password;
    public string Description;

}