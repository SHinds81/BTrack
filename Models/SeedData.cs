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

            context.SaveChanges();
            
            // Look for any accounts.
            if (context.Account.Any())
            {
                return;   // DB has been seeded
            }

            context.Account.AddRange(
                new Account { accountName = "John Doe", username = "john_doe" },
                new Account { accountName = "Jane Smith", username = "jane_smith" },
                new Account { accountName = "Bob Johnson", username = "bob_johnson" },
                new Account { accountName = "Alice Williams", username = "alice_williams" },
                new Account { accountName = "Charlie Brown", username = "charlie_brown" },
                new Account { accountName = "Emily Davis", username = "emily_davis" },
                new Account { accountName = "Michael Miller", username = "michael_miller" },
                new Account { accountName = "Sarah Wilson", username = "sarah_wilson" },
                new Account { accountName = "James Moore", username = "james_moore" },
                new Account { accountName = "Jessica Taylor", username = "jessica_taylor" }
            );
            context.SaveChanges();
            
            
            // Look for any bugs.
            if (context.Bugs.Any())
            {
                return;   // DB has been seeded
            }

            context.Bugs.AddRange(
                new Bugs { bugStatus = 1, bugTitle = "UI Bug", bugDescription = "Minor UI bug causing misalignment of elements on the homepage.", bugPriority = 3 },
                new Bugs { bugStatus = 2, bugTitle = "Performance Issue", bugDescription = "The application slows down significantly when more than 100 items are added to the cart.", bugPriority = 2},
                new Bugs { bugStatus = 3, bugTitle = "Security Vulnerability", bugDescription = "A security vulnerability was found in the user login module that could potentially allow unauthorized access.", bugPriority = 1},
                new Bugs { bugStatus = 1, bugTitle = "Deprecated API", bugDescription = "The application uses a deprecated API for the payment gateway.", bugPriority = 2},
                new Bugs { bugStatus = 2, bugTitle = "Data Sync Bug", bugDescription = "A bug in the data synchronization module causes outdated data to be displayed.", bugPriority = 3},
                new Bugs { bugStatus = 3, bugTitle = "Payment Gateway Bug", bugDescription = "A bug in the payment gateway causes transactions to fail intermittently.", bugPriority = 1},
                new Bugs { bugStatus = 1, bugTitle = "Shopping Cart Issue", bugDescription = "Items added to the shopping cart disappear after a few minutes.", bugPriority = 2},
                new Bugs { bugStatus = 2, bugTitle = "Order Tracking Bug", bugDescription = "The order tracking system shows incorrect status for some orders.", bugPriority = 3},
                new Bugs { bugStatus = 3, bugTitle = "UI Usability Issue", bugDescription = "Some users have reported difficulty in navigating the user interface.", bugPriority = 2},
                new Bugs { bugStatus = 1, bugTitle = "Page Load Time Bug", bugDescription = "Some pages take a long time to load, causing a poor user experience.", bugPriority = 3},
                new Bugs { bugStatus = 2, bugTitle = "Database Connection Bug", bugDescription = "The application fails to connect to the database intermittently.", bugPriority = 1},
                new Bugs { bugStatus = 3, bugTitle = "Product Listing Issue", bugDescription = "Some products do not appear in the product listing page.", bugPriority = 2},
                new Bugs { bugStatus = 1, bugTitle = "User Registration Bug", bugDescription = "New users are unable to register due to a validation error.", bugPriority = 3},
                new Bugs { bugStatus = 2, bugTitle = "Performance Improvement", bugDescription = "The application performance needs to be improved for better user experience.", bugPriority = 2},
                new Bugs { bugStatus = 3, bugTitle = "Data Display Bug", bugDescription = "Incorrect data is displayed on the user profile page.", bugPriority = 3},
                new Bugs { bugStatus = 1, bugTitle = "Search Functionality Bug", bugDescription = "The search functionality returns incorrect results.", bugPriority = 2},
                new Bugs { bugStatus = 2, bugTitle = "Email Notification Issue", bugDescription = "Users are not receiving email notifications.", bugPriority = 3},
                new Bugs { bugStatus = 3, bugTitle = "Data Backup Bug", bugDescription = "The data backup process fails intermittently.", bugPriority = 1},
                new Bugs { bugStatus = 1, bugTitle = "User Interface Improvement", bugDescription = "The user interface needs to be updated for better accessibility.", bugPriority = 2},
                new Bugs { bugStatus = 2, bugTitle = "Data Loss Bug", bugDescription = "A bug causing data loss when updating user profiles.", bugPriority = 3}
            );

            context.SaveChanges();
            
            if (context.Update.Any())
            {
                return;   // DB has been seeded
            }

            context.Update.AddRange(
                new Update { bugId = 1, accountId = 2, updateDate = DateTime.Parse("2023-09-04"), updateDetails = "Bug entered in system" },
                new Update { bugId = 2, accountId = 3, updateDate = DateTime.Parse("2023-09-03"), updateDetails = "Bug entered in system" },
                new Update { bugId = 3, accountId = 4, updateDate = DateTime.Parse("2023-09-02"), updateDetails = "Bug entered in system" },
                new Update { bugId = 4, accountId = 5, updateDate = DateTime.Parse("2023-09-02"), updateDetails = "Bug entered in system" },
                new Update { bugId = 5, accountId = 6, updateDate = DateTime.Parse("2023-09-01"), updateDetails = "Bug entered in system" },
                new Update { bugId = 6, accountId = 7, updateDate = DateTime.Parse("2023-08-30"), updateDetails = "Bug entered in system" },
                new Update { bugId = 7, accountId = 8, updateDate = DateTime.Parse("2023-08-29"), updateDetails = "Bug entered in system" },
                new Update { bugId = 8, accountId = 9, updateDate = DateTime.Parse("2023-08-29"), updateDetails = "Bug entered in system" },
                new Update { bugId = 9, accountId = 10, updateDate = DateTime.Parse("2023-08-27"), updateDetails = "Bug entered in system" },
                new Update { bugId = 10, accountId = 11, updateDate = DateTime.Parse("2023-08-27"), updateDetails = "Bug entered in system" },
                new Update { bugId = 11, accountId = 2, updateDate = DateTime.Parse("2023-08-25"), updateDetails = "Bug entered in system" },
                new Update { bugId = 12, accountId = 3, updateDate = DateTime.Parse("2023-08-24"), updateDetails = "Bug entered in system" },
                new Update { bugId = 13, accountId = 4, updateDate = DateTime.Parse("2023-08-24"), updateDetails = "Bug entered in system" },
                new Update { bugId = 14, accountId = 5, updateDate = DateTime.Parse("2023-08-22"), updateDetails = "Bug entered in system" },
                new Update { bugId = 15, accountId = 6, updateDate = DateTime.Parse("2023-08-21"), updateDetails = "Bug entered in system" },
                new Update { bugId = 16, accountId = 7, updateDate = DateTime.Parse("2023-08-20"), updateDetails = "Bug entered in system" },
                new Update { bugId = 17, accountId = 8, updateDate = DateTime.Parse("2023-08-19"), updateDetails = "Bug entered in system" },
                new Update { bugId = 18, accountId = 9, updateDate = DateTime.Parse("2023-08-19"), updateDetails = "Bug entered in system" },
                new Update { bugId = 19, accountId = 10, updateDate = DateTime.Parse("2023-08-18"), updateDetails = "Bug entered in system" },
                new Update { bugId = 20, accountId = 11, updateDate = DateTime.Parse("2023-08-17"), updateDetails = "Bug entered in system" },
                new Update { bugId = 1, accountId = 2, updateDate = DateTime.Parse("2023-09-25"), updateDetails = "Fixed a minor UI bug" },
                new Update { bugId = 2, accountId = 3, updateDate = DateTime.Parse("2023-09-24"), updateDetails = "Resolved performance issue" },
                new Update { bugId = 1, accountId = 4, updateDate = DateTime.Parse("2023-09-23"), updateDetails = "Patched security vulnerability" },
                new Update { bugId = 12, accountId = 5, updateDate = DateTime.Parse("2023-09-22"), updateDetails = "Updated deprecated API calls" },
                new Update { bugId = 13, accountId = 6, updateDate = DateTime.Parse("2023-09-21"), updateDetails = "Corrected data synchronization bug" },
                new Update { bugId = 17, accountId = 7, updateDate = DateTime.Parse("2023-09-20"), updateDetails = "Fixed a bug causing app crashes" },
                new Update { bugId = 15, accountId = 8, updateDate = DateTime.Parse("2023-09-19"), updateDetails = "Resolved issue with user login" },
                new Update { bugId = 19, accountId = 9, updateDate = DateTime.Parse("2023-09-18"), updateDetails = "Patched a memory leak issue" },
                new Update { bugId = 9, accountId = 10, updateDate = DateTime.Parse("2023-09-17"), updateDetails = "Updated the app to support the latest OS version" },
                new Update { bugId = 10, accountId = 11, updateDate = DateTime.Parse("2023-09-16"), updateDetails = "Corrected a data loss issue" },
                new Update { bugId = 11, accountId = 2, updateDate = DateTime.Parse("2023-09-15"), updateDetails = "Fixed a bug in the payment gateway" },
                new Update { bugId = 12, accountId = 3, updateDate = DateTime.Parse("2023-09-14"), updateDetails = "Resolved an issue with the shopping cart" },
                new Update { bugId = 13, accountId = 4, updateDate = DateTime.Parse("2023-09-13"), updateDetails = "Patched a bug in the user registration module" },
                new Update { bugId = 5, accountId = 5, updateDate = DateTime.Parse("2023-09-12"), updateDetails = "Updated the database to improve performance" },
                new Update { bugId = 15, accountId = 6, updateDate = DateTime.Parse("2023-09-11"), updateDetails = "Corrected a bug causing incorrect data display" },
                new Update { bugId = 16, accountId = 7, updateDate = DateTime.Parse("2023-09-10"), updateDetails = "Fixed a bug in the search functionality" },
                new Update { bugId = 17, accountId = 8, updateDate = DateTime.Parse("2023-09-09"), updateDetails = "Resolved an issue with the product listing" },
                new Update { bugId = 18, accountId = 9, updateDate = DateTime.Parse("2023-09-08"), updateDetails = "Patched a bug in the order tracking system" },
                new Update { bugId = 19, accountId = 10, updateDate = DateTime.Parse("2023-09-07"), updateDetails = "Updated the user interface to improve usability" },
                new Update { bugId = 1, accountId = 11, updateDate = DateTime.Parse("2023-09-06"), updateDetails = "Corrected a bug causing slow page load times" },
                new Update { bugId = 12, accountId = 2, updateDate = DateTime.Parse("2023-10-24"), updateDetails = "Fixed a bug that was causing the application to crash when loading more than 100 items in the inventory." },
                new Update { bugId = 13, accountId = 3, updateDate = DateTime.Parse("2023-10-23"), updateDetails = "Resolved an issue where users were unable to update their profile information." },
                new Update { bugId = 17, accountId = 4, updateDate = DateTime.Parse("2023-10-23"), updateDetails = "Patched a security vulnerability that could potentially allow unauthorized access to user data." },
                new Update { bugId = 15, accountId = 5, updateDate = DateTime.Parse("2023-10-22"), updateDetails = "Improved application performance by optimizing database queries." },
                new Update { bugId = 19, accountId = 6, updateDate = DateTime.Parse("2023-10-22"), updateDetails = "Updated the user interface to make it more intuitive and user-friendly." },
                new Update { bugId = 6, accountId = 7, updateDate = DateTime.Parse("2023-10-19"), updateDetails = "Corrected a data synchronization issue that was causing outdated data to be displayed." },
                new Update { bugId = 7, accountId = 8, updateDate = DateTime.Parse("2023-10-18"), updateDetails = "Fixed a memory leak that was causing the application to slow down over time." },
                new Update { bugId = 8, accountId = 9, updateDate = DateTime.Parse("2023-10-19"), updateDetails = "Resolved a compatibility issue with the latest version of the operating system." },
                new Update { bugId = 9, accountId = 10, updateDate = DateTime.Parse("2023-10-17"), updateDetails = "Patched a bug in the payment gateway that was causing transactions to fail intermittently." },
                new Update { bugId = 10, accountId = 11, updateDate = DateTime.Parse("2023-10-17"), updateDetails = "Fixed an issue where the search functionality was not returning accurate results." },
                new Update { bugId = 11, accountId = 2, updateDate = DateTime.Parse("2023-10-15"), updateDetails = "Fixed a bug that was causing the application to hang when processing large files." },
                new Update { bugId = 12, accountId = 3, updateDate = DateTime.Parse("2023-10-14"), updateDetails = "Resolved an issue where users were unable to reset their passwords." },
                new Update { bugId = 1, accountId = 4, updateDate = DateTime.Parse("2023-10-13"), updateDetails = "Patched a security vulnerability that could potentially allow injection attacks." },
                new Update { bugId = 12, accountId = 5, updateDate = DateTime.Parse("2023-10-12"), updateDetails = "Improved application performance by reducing memory usage." },
                new Update { bugId = 13, accountId = 6, updateDate = DateTime.Parse("2023-10-10"), updateDetails = "Updated the color scheme to improve visibility for color-blind users." },
                new Update { bugId = 17, accountId = 7, updateDate = DateTime.Parse("2023-10-09"), updateDetails = "Corrected a data integrity issue that was causing discrepancies in reports." },
                new Update { bugId = 15, accountId = 8, updateDate = DateTime.Parse("2023-10-08"), updateDetails = "Fixed a resource leak that was causing the application to consume excessive CPU." },
                new Update { bugId = 5, accountId = 9, updateDate = DateTime.Parse("2023-10-09"), updateDetails = "Resolved a compatibility issue with certain mobile devices." },
                new Update { bugId = 19, accountId = 10, updateDate = DateTime.Parse("2023-10-08"), updateDetails = "Patched a bug in the email system that was causing some emails to be marked as spam." },
                new Update { bugId = 20, accountId = 11, updateDate = DateTime.Parse("2023-10-07"), updateDetails = "Fixed an issue where the search functionality was not indexing new content." },
                new Update { bugId = 1, accountId = 2, updateDate = DateTime.Parse("2023-10-14"), updateDetails = "Fixed a bug that was causing unexpected logout for users after a certain period of inactivity." },
                new Update { bugId = 2, accountId = 3, updateDate = DateTime.Parse("2023-10-14"), updateDetails = "Resolved an issue where users were unable to download attachments from the application." },
                new Update { bugId = 3, accountId = 4, updateDate = DateTime.Parse("2023-10-13"), updateDetails = "Patched a security vulnerability that could potentially allow cross-site scripting attacks." },
                new Update { bugId = 4, accountId = 5, updateDate = DateTime.Parse("2023-10-13"), updateDetails = "Improved application performance by implementing lazy loading for images." },
                new Update { bugId = 1, accountId = 6, updateDate = DateTime.Parse("2023-10-13"), updateDetails = "Updated the navigation menu to make it more user-friendly and intuitive." },
                new Update { bugId = 12, accountId = 7, updateDate = DateTime.Parse("2023-10-09"), updateDetails = "Corrected a data validation issue that was allowing invalid data to be entered in certain fields." },
                new Update { bugId = 13, accountId = 8, updateDate = DateTime.Parse("2023-10-09"), updateDetails = "Fixed a concurrency issue that was causing data inconsistency when multiple users update the same record simultaneously." },
                new Update { bugId = 17, accountId = 9, updateDate = DateTime.Parse("2023-10-09"), updateDetails = "Resolved a compatibility issue with the latest web browsers." },
                new Update { bugId = 15, accountId = 10, updateDate = DateTime.Parse("2023-10-07"), updateDetails = "Patched a bug in the notification system that was causing duplicate notifications to be sent." },
                new Update { bugId = 19, accountId = 11, updateDate = DateTime.Parse("2023-10-08"), updateDetails = "Fixed an issue where the pagination was not working correctly in the transaction history page." },
                new Update { bugId = 1, accountId = 2, updateDate = DateTime.Parse("2023-11-20"), updateDetails = "Bug closed in system" },
                new Update { bugId = 12, accountId = 2, updateDate = DateTime.Parse("2023-11-19"), updateDetails = "Bug closed in system" },
                new Update { bugId = 13, accountId = 10, updateDate = DateTime.Parse("2023-11-17"), updateDetails = "Bug closed in system" },
                new Update { bugId = 17, accountId = 2, updateDate = DateTime.Parse("2023-11-16"), updateDetails = "Bug closed in system" },
                new Update { bugId = 5, accountId = 6, updateDate = DateTime.Parse("2023-11-14"), updateDetails = "Bug closed in system" },
                new Update { bugId = 19, accountId = 9, updateDate = DateTime.Parse("2023-11-13"), updateDetails = "Bug closed in system" }
            );
            context.SaveChanges();
            
        }
    }
}