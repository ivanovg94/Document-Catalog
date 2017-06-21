using DocCat.Models;
using DocCat.ViewModels;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DocCat.Views.Customer
{
    public partial class MyDocuments : System.Web.UI.Page
    {
        DCDbContext context = new DCDbContext();
        private const int notRequested = 1;
        private const int requested = 2;
        private const int approved = 3;

        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                PopulateGV();
            }
        }

        private void PopulateGV()
        {
            var currentUserId = User.Identity.GetUserId();

            var gridData = context.Documents
                  .Where(x => x.IssuedBy.Id == currentUserId)
                  .Include(x => x.DocType)
                  .Include(x => x.RequestStatus)
                                        .Select(x => new CustomerDocsVM()
                                        {
                                            Id = x.Id,
                                            Name = x.Name,
                                            IssueTo = x.IssuedTo,
                                            DateNTime = x.Date,
                                            Type = x.DocType.Name,
                                            Description = x.Description,
                                            Status = x.RequestStatus.Name
                                        })
                  .ToList();
            DocumentsGV.DataSource = gridData;
            DocumentsGV.DataBind();
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


            if (e.CommandName == "Request")
            {
                index = Convert.ToInt32(e.CommandArgument);
                row = grid.Rows[index];
                id = int.Parse(row.Cells[0].Text);
                var document = context.Documents.Find(id);

                if (document.RequestStatusId == notRequested)
                {
                    document.RequestStatusId = requested;
                    context.SaveChanges();
                    PopulateGV();
                }
            }
        }
    }
}