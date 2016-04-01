namespace DatabaseProjectIAmDb.DataContexts.IdentityMigrations
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using Models;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DatabaseProjectIAmDb.DataContexts.IdentityDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"DataContexts\IdentityMigrations";
        }

        protected override void Seed(IdentityDb context)
        {
            var roleStore = new RoleStore<IdentityRole>(context);
            var roleManager = new RoleManager<IdentityRole>(roleStore);


            if (!context.Roles.Any(r => r.Name == "Admin"))
            {
                roleManager.Create(new IdentityRole { Name = "Admin" });
            }

            if (!context.Roles.Any(r => r.Name == "SuperVolunteer"))
            {
                roleManager.Create(new IdentityRole { Name = "SuperVolunteer" });
            }

            if (!context.Roles.Any(r => r.Name == "Volunteer"))
            {
                roleManager.Create(new IdentityRole { Name = "Volunteer" });
            }

            var userStore = new UserStore<ApplicationUser>(context);
            var userManager = new UserManager<ApplicationUser>(userStore);

            if (!context.Users.Any(u => u.UserName == "admin@test.com"))
            {
                var user = new ApplicationUser
                {
                    Email = "admin@test.com",
                    UserName = "admin@test.com"
                };
                userManager.Create(user, "Pass1!");
                userManager.AddToRole(user.Id, "Admin");
            }
        }
    }
}
