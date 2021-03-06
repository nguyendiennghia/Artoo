﻿using Microsoft.AspNetCore.Identity;

namespace Artoo.Models
{
    public static class DbInitializer
    {
        public static void Seed(AppDbContext context, RoleManager<IdentityRole> roleManager, UserManager<ApplicationUser> userManager)
        {
            //AppDbContext context = applicationBuilder.ApplicationServices.GetRequiredService<AppDbContext>();

            context.Database.EnsureCreated();
            context.SaveChanges();
            SeedRoles(roleManager);
            SeedUser(userManager);
        }

        public static void SeedRoles(RoleManager<IdentityRole> roleManager)
        {
            if (!roleManager.RoleExistsAsync("Administrator").Result)
            {
                IdentityRole role = new IdentityRole();
                role.Name = "Administrator";
                //role.Description = "Perform all the operations.";
                IdentityResult roleResult = roleManager.CreateAsync(role).Result;
            }

            if (!roleManager.RoleExistsAsync("Factory Manager").Result)
            {
                IdentityRole role = new IdentityRole();
                role.Name = "Factory Manager";
                //role.Description = "Perform normal operations.";
                IdentityResult roleResult = roleManager.CreateAsync(role).Result;
            }

            if (!roleManager.RoleExistsAsync("Decathlon Manager").Result)
            {
                IdentityRole role = new IdentityRole();
                role.Name = "Decathlon Manager";
                //role.Description = "Perform normal operations.";
                IdentityResult roleResult = roleManager.CreateAsync(role).Result;
            }

            if (!roleManager.RoleExistsAsync("QPL").Result)
            {
                IdentityRole role = new IdentityRole();
                role.Name = "QPL";
                //role.Description = "Perform normal operations.";
                IdentityResult roleResult = roleManager.CreateAsync(role).Result;
            }
        }

        public static void SeedUser(UserManager<ApplicationUser> userManager)
        {
            if (userManager.FindByNameAsync("admin").Result == null)
            {
                ApplicationUser user = new ApplicationUser();
                user.UserName = "admin";
                user.Email = "admin@artoo.com";

                IdentityResult result = userManager.CreateAsync
                (user, "Admin123.").Result;

                if (result.Succeeded)
                {
                    userManager.AddToRoleAsync(user,
                                        "Administrator").Wait();
                }
            }
        }
    }
}
