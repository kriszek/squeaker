using Microsoft.AspNet.Identity.EntityFramework;
using Squeaker.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Squeaker.DataAccess
{
    public class DbInitiliazer : DropCreateDatabaseIfModelChanges<SqueakerContext>
    {
        private string LoremIpsum { get; } = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.";

        protected override void Seed(SqueakerContext context)
        {
            ApplicationUser user1 = new ApplicationUser
            {
                Id = NewGuid(),
                Email = "ben@then.com",
                EmailConfirmed = false,
                PasswordHash = "AKmuq7KtNQPlrYyl4bLxENYXZAeo2gENPviE4GKYD2g8pFa0oQQLr6YyrKZLu/YPyg==",
                SecurityStamp = "3c98543e-05ef-4a7e-8649-6cb9b1cd01ed",
                UserName = "Ben",
                Squeaks = new List<Squeak>(),
            };

            Squeak squeak1 = new Squeak
            {
                Text = "Squeak1. " + LoremIpsum,
                CreationDate = DateTimeOffset.Now.AddDays(-2)
            };

            Squeak squeak2 = new Squeak
            {
                Text = "Squeak2. " + LoremIpsum,
                CreationDate = DateTimeOffset.Now.AddDays(-1)
            };

            user1.Squeaks.Add(squeak1);
            user1.Squeaks.Add(squeak2);

            context.Users.Add(user1);
            context.SaveChanges();

            IdentityRole adminRole = new IdentityRole
            {
                Id = NewGuid(),
                Name = "Admin"
            };

            IdentityRole customerRole = new IdentityRole
            {
                Id = NewGuid(),
                Name = "Customer"
            };

            context.Roles.Add(adminRole);
            context.Roles.Add(customerRole);

            IdentityUserRole user1Role1 = new IdentityUserRole
            {
                RoleId = customerRole.Id,
                UserId = user1.Id,
            };

            context.UserRoles.Add(user1Role1);
            context.SaveChanges();
        }

        private static string NewGuid()
        {
            return Guid.NewGuid().ToString();
        }
    }
}
