﻿namespace BlogEf.Models;

public class User
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string PasswordHash { get; set; }
    public string Bio { get; set; }
    public string Image { get; set; }
    public string Slug { get; set; }
    public List<Role> Role { get; set; }

    public User()
    {
        Role = new List<Role>();
    }
}