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


            // Look for any bugs.
            if (context.Bugs.Any())
            {
                return;   // DB has been seeded
            }

            context.Bugs.AddRange(
                new Bugs { bugId = 1001, bugStatus = 1, bugTitle = "UI Bug", bugDescription = "Minor UI bug causing misalignment of elements on the homepage.", bugPriority = 3 },
                new Bugs { bugId = 1002, bugStatus = 2, bugTitle = "Performance Issue", bugDescription = "The application slows down significantly when more than 100 items are added to the cart.", bugPriority = 2},
                new Bugs { bugId = 1003, bugStatus = 3, bugTitle = "Security Vulnerability", bugDescription = "A security vulnerability was found in the user login module that could potentially allow unauthorized access.", bugPriority = 1},
                new Bugs { bugId = 1004, bugStatus = 1, bugTitle = "Deprecated API", bugDescription = "The application uses a deprecated API for the payment gateway.", bugPriority = 2},
                new Bugs { bugId = 1005, bugStatus = 2, bugTitle = "Data Sync Bug", bugDescription = "A bug in the data synchronization module causes outdated data to be displayed.", bugPriority = 3},
                new Bugs { bugId = 1006, bugStatus = 3, bugTitle = "Payment Gateway Bug", bugDescription = "A bug in the payment gateway causes transactions to fail intermittently.", bugPriority = 1},
                new Bugs { bugId = 1007, bugStatus = 1, bugTitle = "Shopping Cart Issue", bugDescription = "Items added to the shopping cart disappear after a few minutes.", bugPriority = 2},
                new Bugs { bugId = 1008, bugStatus = 2, bugTitle = "Order Tracking Bug", bugDescription = "The order tracking system shows incorrect status for some orders.", bugPriority = 3},
                new Bugs { bugId = 1009, bugStatus = 3, bugTitle = "UI Usability Issue", bugDescription = "Some users have reported difficulty in navigating the user interface.", bugPriority = 2},
                new Bugs { bugId = 1010, bugStatus = 1, bugTitle = "Page Load Time Bug", bugDescription = "Some pages take a long time to load, causing a poor user experience.", bugPriority = 3},
                new Bugs { bugId = 1011, bugStatus = 2, bugTitle = "Database Connection Bug", bugDescription = "The application fails to connect to the database intermittently.", bugPriority = 1},
                new Bugs { bugId = 1012, bugStatus = 3, bugTitle = "Product Listing Issue", bugDescription = "Some products do not appear in the product listing page.", bugPriority = 2},
                new Bugs { bugId = 1013, bugStatus = 1, bugTitle = "User Registration Bug", bugDescription = "New users are unable to register due to a validation error.", bugPriority = 3},
                new Bugs { bugId = 1014, bugStatus = 2, bugTitle = "Performance Improvement", bugDescription = "The application performance needs to be improved for better user experience.", bugPriority = 2},
                new Bugs { bugId = 1015, bugStatus = 3, bugTitle = "Data Display Bug", bugDescription = "Incorrect data is displayed on the user profile page.", bugPriority = 3},
                new Bugs { bugId = 1016, bugStatus = 1, bugTitle = "Search Functionality Bug", bugDescription = "The search functionality returns incorrect results.", bugPriority = 2},
                new Bugs { bugId = 1017, bugStatus = 2, bugTitle = "Email Notification Issue", bugDescription = "Users are not receiving email notifications.", bugPriority = 3},
                new Bugs { bugId = 1018, bugStatus = 3, bugTitle = "Data Backup Bug", bugDescription = "The data backup process fails intermittently.", bugPriority = 1},
                new Bugs { bugId = 1019, bugStatus = 1, bugTitle = "User Interface Improvement", bugDescription = "The user interface needs to be updated for better accessibility.", bugPriority = 2},
                new Bugs { bugId = 1020, bugStatus = 2, bugTitle = "Data Loss Bug", bugDescription = "A bug causing data loss when updating user profiles.", bugPriority = 3}
            );


            context.SaveChanges();
            
        }
    }
}