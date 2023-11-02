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
            // Look for any logins.
            if (context.Login.Any())
            {
                return;   // DB has been seeded
            }
            
            context.Login.AddRange(
                new Login { username = "john_doe", password = "jd123456"},
                new Login { username = "jane_smith", password = "js123456"},
                new Login { username = "bob_johnson", password = "bj123456"},
                new Login { username = "alice_williams", password = "aw123456"},
                new Login { username = "charlie_brown", password = "cb123456"},
                new Login { username = "emily_davis", password = "ed123456"},
                new Login { username = "michael_miller", password = "mm123456"},
                new Login { username = "sarah_wilson", password = "sw123456"},
                new Login { username = "james_moore", password = "jm123456"},
                new Login { username = "jessica_taylor", password = "jt123456"}
            );

            // Look for any accounts.
            if (context.Account.Any())
            {
                return;   // DB has been seeded
            }

            context.Account.AddRange(
                new Account { accountId = 101, accountName = "John Doe", username = "john_doe"},
                new Account { accountId = 102, accountName = "Jane Smith", username = "jane_smith"},
                new Account { accountId = 103, accountName = "Bob Johnson", username = "bob_johnson"},
                new Account { accountId = 104, accountName = "Alice Williams", username = "alice_williams"},
                new Account { accountId = 105, accountName = "Charlie Brown", username = "charlie_brown"},
                new Account { accountId = 106, accountName = "Emily Davis", username = "emily_davis"},
                new Account { accountId = 107, accountName = "Michael Miller", username = "michael_miller"},
                new Account { accountId = 108, accountName = "Sarah Wilson", username = "sarah_wilson"},
                new Account { accountId = 109, accountName = "James Moore", username = "james_moore"},
                new Account { accountId = 110, accountName = "Jessica Taylor", username = "jessica_taylor"}
            );


            context.SaveChanges();
            
        }
    }
}