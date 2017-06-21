using DocCat.Message;
using DocCat.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DocCat.Views.Details
{
    public partial class DocumentDetails : System.Web.UI.Page
    {
        DCDbContext context = new DCDbContext();
        int queryStringID;
        protected void Page_Load(object sender, EventArgs e)
        {
            queryStringID = int.Parse(Request.QueryString["id"]);
            var currentDoc = context.Documents.Find(queryStringID);
            CurrentDocNameL.Text = currentDoc.Name;
            TypeL.Text = currentDoc.DocType.Name;
            IssuedToL.Text = currentDoc.IssuedTo;
            IssuedByL.Text = currentDoc.IssuedBy.Name;
            SavedByL.Text = currentDoc.SavedBy;
            DateL.Text = currentDoc.Date.ToShortDateString();
            RequestStatusL.Text = currentDoc.RequestStatus.Name;

            StorageL.Text = currentDoc.Box.Row.Shelf.Warehouse.Name;
            ShelfL.Text = currentDoc.Box.Row.Shelf.Number;
            RowL.Text = currentDoc.Box.Row.Number;
            BoxL.Text = currentDoc.Box.Number;
            DigithalPath.Text = "TODO:!";

            DescriptionL.Text = currentDoc.Description;
            if (currentDoc.RequestStatusId != 1)
            {
                RequestBtn.Enabled = false;
            }
            if (currentDoc.IssuedBy.Id != User.Identity.GetUserId())
            {
                RequestBtn.Visible = false;
                DownloadBtn.Visible = false;
            }
            if (context.Users.FirstOrDefault(x => x.Name == currentDoc.SavedBy).Id != User.Identity.GetUserId())
            {
                ApproveBtn.Visible = false;
            }
            else
            {
                if (currentDoc.RequestStatusId != 2)
                {
                    ApproveBtn.Enabled = false;
                }
            }

        }

        protected void RequestBtn_Click(object sender, EventArgs e)
        {
            var currentDoc = context.Documents.Find(queryStringID);
            currentDoc.RequestStatusId = 2;
            MessageBox.Show(this, "Заявката е успешна!");
        }

        protected void Approve_Click(object sender, EventArgs e)
        {
            var currentDoc = context.Documents.Find(queryStringID);
            currentDoc.RequestStatusId = 3;
            context.SaveChanges();
            RequestStatusL.Text = currentDoc.RequestStatus.Name;
            ApproveBtn.Enabled = false;        
            

        }
    }
}