using DocCat.Models;
using DocCat.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DocCat.Views.Admin
{
    public partial class AllOperators : System.Web.UI.Page
    {

        DCDbContext context = new DCDbContext();
        private const string customerRoleId = "c64a4ee6-b02f-40df-957e-edfaff297265";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                var gridData = context.Users
                   .Where(x => x.Roles.FirstOrDefault().RoleId == customerRoleId)
                   .Select(x => new OperatorsVM()
                   {
                       Name = x.Name,
                       SavedDocumentsCount = context.Documents.Where(y => y.SavedBy == x.Name).Count()
                   })
      .ToList();
                OperatorsGV.DataSource = gridData;
                OperatorsGV.DataBind();
            }
        }
    }
}
