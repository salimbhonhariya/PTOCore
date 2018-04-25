using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using PTOCore.Models;
using System;

namespace PTOCore.Data
{
    public class DbInitializer : IDbInitializer
    {

//        public static void Initialize(ApplicationDbContext context)
//        {
//             context.Database.Migrate();
//            //context.Database.EnsureCreated();

//            // Look for Employee With Time entered
//            //if (context.Groups.Any())
//            //    return;   // DB has been seeded

//            var rootEmployee = context.EmployeePTOs.Where(g => g.EmployeeId != Convert.ToInt32(string.Empty));
//            if (rootEmployee == null)
//            {
//#if DEBUG
//                var EmployeePTOs = new EmployeePTO()
//                {
//                    EmployeeId = 1,
//                    FirstName = "Salim"
//                };

//                context.EmployeePTOs.Add(EmployeePTOs);
//                context.SaveChanges();
//            }


//#endif
//            // NOTE: The seeded data is necessary for the client integration tests to successfully pass.
//        }
        private readonly IServiceProvider _serviceProvider;

        public DbInitializer(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        //This example just creates an Administrator role and one Admin users
        public async void Initialize()
        {
            using (var serviceScope = _serviceProvider.GetRequiredService<IServiceScopeFactory>().CreateScope())
            {
                //create database schema if none exists
                var context = serviceScope.ServiceProvider.GetService<ApplicationDbContext>();
                context.Database.EnsureCreated();

                //If there is already an Administrator role, abort
                var _roleManager = serviceScope.ServiceProvider.GetService<RoleManager<ApplicationRole>>();
                if (!(await _roleManager.RoleExistsAsync("Administrator")))
                {
                    //Create the Administartor Role
                    await _roleManager.CreateAsync(new ApplicationRole("Administrator"));
                }
                //Create the default Admin account and apply the Administrator role
                var _userManager = serviceScope.ServiceProvider.GetService<UserManager<ApplicationUser>>();
                string user = "xxx@yyy.com";
                string password = "AbC!12345";
                var success = await _userManager.CreateAsync(new ApplicationUser { UserName = user, Email = user, EmailConfirmed = true }, password);
                if (success.Succeeded)
                {
                    await _userManager.AddToRoleAsync(await _userManager.FindByNameAsync(user), "Administrator");
                }

            }

        }
    }
}
