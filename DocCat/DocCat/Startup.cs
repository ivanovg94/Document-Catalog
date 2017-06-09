using DocCat.Migrations;
using DocCat.Models;
using Microsoft.Owin;
using Owin;
using System.Data.Entity;

[assembly: OwinStartupAttribute(typeof(DocCat.Startup))]
namespace DocCat
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {

            Database.SetInitializer(
              new MigrateDatabaseToLatestVersion<DCDbContext, Configuration>());

            ConfigureAuth(app);

            DCDbContext.Create().Database.Initialize(true);

        }
    }
}
