namespace DocCat.Migrations
{
    using DocCat.Models;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;


    public sealed class Configuration : DbMigrationsConfiguration<DCDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "DocCat.Models.DCDbContext";
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(DCDbContext context)
        {
            RolesSeeder(context);
            UsersSeeder(context);
            DocTypeSeeder(context);
            RequestStatusSeeder(context);

        }

        private void RequestStatusSeeder(DCDbContext context)
        {
            context.RequestStatus.AddOrUpdate(new RequestStatus()
            {
                Id = 1,
                Name = "��������"
            });

            context.RequestStatus.AddOrUpdate(new RequestStatus()
            {
                Id = 2,
                Name = "������"
            });

            context.RequestStatus.AddOrUpdate(new RequestStatus()
            {
                Id = 3,
                Name = "��������"
            });
        }

        private void DocTypeSeeder(DCDbContext context)
        {
            context.DocTypes.AddOrUpdate(new DocType()
            {
                Id = 1,
                Name = "������ �������"
            });

            context.DocTypes.AddOrUpdate(new DocType()
            {
                Id = 2,
                Name = "���������� ��������������"
            });

            context.DocTypes.AddOrUpdate(new DocType()
            {
                Id = 3,
                Name = "�������� �� �����������"
            });

            context.DocTypes.AddOrUpdate(new DocType()
            {
                Id = 4,
                Name = "�������� �� ��������� �����������"
            });

            context.DocTypes.AddOrUpdate(new DocType()
            {
                Id = 5,
                Name = "������������ �� ��������"
            });

        }

        private void RolesSeeder(DCDbContext context)
        {
            var roleStore = new RoleStore<IdentityRole>(context);
            var roleManager = new RoleManager<IdentityRole>(roleStore);

            var roleAdmin = new IdentityRole() { Name = "admin" };
            var roleOperator = new IdentityRole() { Name = "operator" };
            var roleCustomer = new IdentityRole() { Name = "customer" };

            if (!context.Roles.Any(role => role.Name == "admin"))
            {
                roleManager.Create(roleAdmin);
            }

            if (!context.Roles.Any(role => role.Name == "operator"))
            {
                roleManager.Create(roleOperator);
            }

            if (!context.Roles.Any(role => role.Name == "customer"))
            {
                roleManager.Create(roleCustomer);
            }
        }

        private void UsersSeeder(DCDbContext context)
        {
            var userStore = new UserStore<ApplicationUser>(context);
            var userManager = new UserManager<ApplicationUser>(userStore);

            userManager.PasswordValidator = new PasswordValidator
            {
                RequiredLength = 1,
                RequireDigit = false,
                RequireLowercase = false,
                RequireNonLetterOrDigit = false,
                RequireUppercase = false,
            };

            if (!context.Users.Any(u => u.UserName == "admin@admin.com"))
            {
                var userAdmin = new ApplicationUser
                {
                    UserName = "admin@admin.com",
                    Email = "admin@admin.com",
                };

                userManager.Create(userAdmin, "123");
                userManager.AddToRole(userAdmin.Id, "admin");
            }

            if (!context.Users.Any(u => u.UserName == "operator@doc.com"))
            {
                var userOperator = new ApplicationUser
                {
                    UserName = "operator@doc.com",
                    Email = "operator@doc.com",
                    Name = "���� �����"
                };

                userManager.Create(userOperator, "123");
                userManager.AddToRole(userOperator.Id, "operator");
            }

            if (!context.Users.Any(u => u.UserName == "companyOne@gmail.com"))
            {
                var userCompany = new ApplicationUser
                {
                    UserName = "companyOne@gmail.com",
                    Email = "companyOne@gmail.com",
                    Name = "One Company"
                };

                userManager.Create(userCompany, "123");
                userManager.AddToRole(userCompany.Id, "customer");
            }
        }

    }
}
