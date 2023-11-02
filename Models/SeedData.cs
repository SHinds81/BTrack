using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using BTrack.Data;
using System;
using System.Linq;

namespace BTrack.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new BTrackContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<BTrackContext>>()))
        {
            // Look for any movies.
            if (context.Login.Any())
            {
                return;   // DB has been seeded
            }
            
            context.Login.AddRange(
                new Login
                { 
                    username: "john_doe",
                    password: "jd123456"
                },
                new Movie
                {
                    Title = "Ghostbusters ",
                    ReleaseDate = DateTime.Parse("1984-3-13"),
                    Genre = "Comedy",
                    Price = 8.99M
                },
                
    { "username": "jane_smith", "password": "js123456"},
    { "username": "bob_johnson", "password": "bj123456"},
    { "username": "alice_williams", "password": "aw123456"},
    { "username": "charlie_brown", "password": "cb123456"},
    { "username": "emily_davis", "password": "ed123456"},
    { "username": "michael_miller", "password": "mm123456"},
    { "username": "sarah_wilson", "password": "sw123456"},
    { "username": "james_moore", "password": "jm123456"},
    { "username": "jessica_taylor", "password": "jt123456"}
            );
            context.SaveChanges();
            
        }
    }
}