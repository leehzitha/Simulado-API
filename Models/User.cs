namespace simulado.Models; 
using System;

public class User
{
    public int ID { get; set; }
    public string Username { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string Description { get; set; }
    public DateTime AccountCreation { get; set; }

    public ICollection<Fanfic> FanficsCreated { get; set; } = [];
}