using DocCat.Models;
using DocCat.ViewModels;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DocCat.Views.Operator
{
    public partial class AllDocuments : System.Web.UI.Page
    {
        DCDbContext context = new DCDbContext();
         

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                var currentUserId = User.Identity.GetUserId();
                var currentUser = context.Users.FirstOrDefault(x => x.Id == currentUserId);

                var gridData = context.Documents
                      .Where(x => x.SavedBy == currentUser.Name)
                      .Include(x => x.DocType)
                      .Include(x => x.RequestStatus)
                                            .Select(x => new OperatorDocsVM()
                                            {
                                                Id = x.Id,
                                                Name = x.Name,
                                                Type = x.DocType.Name,
                                                IssueBy = x.IssuedBy.Name,
                                                Status=x.RequestStatus.Name
                                            })
                      .ToList();
                DocumentsGV.DataSource = gridData;
                DocumentsGV.DataBind();
            }
        }

        protected void DocumentsGV_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            e.Row.Cells[0].Visible = false;
        }

        protected void Grid_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int index = 0;
            int id = -1;
            GridViewRow row;
            GridView grid = sender as GridView;

            if (e.CommandName == "Details")
            {
                index = Convert.ToInt32(e.CommandArgument);
                row = grid.Rows[index];
                id = int.Parse(row.Cells[0].Text);
                Response.Redirect("~/Views/Details/DocumentDetails.aspx?id=" + id.ToString());
            }

            if (e.CommandName == "Approve")
            {
                index = Convert.ToInt32(e.CommandArgument);
                row = grid.Rows[index];
                id = int.Parse(row.Cells[0].Text);
                var selectedDoc = context.Documents.Find(id);
                selectedDoc.RequestStatusId = 3;
            }
        }
    }
}
