using Microsoft.AspNetCore.Identity;
using TechGate.Infrastructure.Data.Models;

namespace TechGate.Extensions.Identity
{
    public class RoleSeeder
    {
        public static async Task SeedRolesAsync(RoleManager<IdentityRole> roleManager)
        {
            string[] roleNames = { "Admin", "User", "Guest" };

            foreach (var roleName in roleNames)
            {
                var roleExist = await roleManager.RoleExistsAsync(roleName);
                if (!roleExist)
                {
                    var result = await roleManager.CreateAsync(new IdentityRole(roleName));
                    if (!result.Succeeded)
                    {
                        throw new Exception($"Failed to create role {roleName}: {string.Join(", ", result.Errors.Select(e => e.Description))}");
                    }
                }
            }
        }

        public static async Task AssignRolesToExistingUsers(UserManager<User> userManager)
        {
            var users = new List<(string email, string role)>
            {
                ("peter@gmail.com", "Admin"),
                ("stoqn@gmail.com", "User")
            };

            foreach (var (email, role) in users)
            {
                var user = await userManager.FindByEmailAsync(email);
                if (user != null)
                {
                    if (!(await userManager.IsInRoleAsync(user, role)))
                    {
                        var result = await userManager.AddToRoleAsync(user, role);
                        if (!result.Succeeded)
                        {
                            throw new Exception($"Failed to assign role {role} to {email}: {string.Join(", ", result.Errors.Select(e => e.Description))}");
                        }
                    }
                }
                else
                {
                    throw new Exception($"User with email {email} not found.");
                }
            }
        }

    }
}
