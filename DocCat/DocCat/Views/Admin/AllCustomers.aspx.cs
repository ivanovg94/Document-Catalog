using DocCat.Models;
using DocCat.ViewModels;
using System;
using System.Linq;
using System.Web.UI.WebControls;

namespace DocCat.Views.Admin
{
    public partial class AllCustomers : System.Web.UI.Page
    {

        DCDbContext context = new DCDbContext();
        private const string customerRoleId = "c64a4ee6-b02f-40df-957e-edfaff297265";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                var gridData = context.Users.Where(x => x.Roles.FirstOrDefault().RoleId == customerRoleId)
                                  .Select(x => new CustomersVM()
                                  {
                                      Name = x.Name,
                                      Bulstat = x.Bulstat,
                                      Address = x.Address,
                                      Phone = x.Phone,
                                      DocumentCount = x.Documents.Count()
                                  })
      .ToList();
                ClientsGV.DataSource = gridData;
                ClientsGV.DataBind();
            }
        }
    }
}