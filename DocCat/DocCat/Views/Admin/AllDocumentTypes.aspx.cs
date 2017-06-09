using DocCat.Models;
using DocCat.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DocCat.Views.Admin
{
    public partial class AllDocumentTypes : System.Web.UI.Page
    {

        DCDbContext context = new DCDbContext();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                var gridData = context.DocTypes
                                  .Select(x => new DocumentTypesVM()
                                  {
                                      TypeName = x.Name,
                                      DocumentsCount = x.Documents.Count()
                                  })
      .ToList();
                LocationGV.DataSource = gridData;
                LocationGV.DataBind();
            }
        }
    }
}