using DocCat.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace DocCat.Views
{
    public partial class NewDocument : System.Web.UI.Page
    {
        DCDbContext context = new DCDbContext();

        protected void Page_Load(object sender, EventArgs e)
        {
            var customerRoleId = context.Roles.FirstOrDefault(x => x.Name == "customer").Id;
            if (!IsPostBack)
            {
                List<ApplicationUser> clients = context.Users.Where(u => u.Roles.Any(r => r.RoleId == customerRoleId)).ToList();
                foreach (var client in clients)
                {
                    IsueByDdl.Items.Add(new ListItem
                    {
                        Text = client.Name,
                        Value = client.Id
                    });
                }

                SaveTypeDdl.Items.Add(
                    new ListItem()
                    {
                        Text = "Автоматично",
                        Value = 0.ToString()
                    });

                SaveTypeDdl.Items.Add(
                    new ListItem()
                    {
                        Text = "Ръчно",
                        Value = 1.ToString()
                    });


                var whList = context.Warehouses.ToList();
                foreach (var wh in whList)
                {
                    WhDdl.Items.Add(
                        new ListItem()
                        {
                            Text = wh.Name,
                            Value = wh.Id.ToString()
                        });
                }

                var docTypes = context.DocTypes.ToList();
                foreach (var type in docTypes)
                {
                    DocTypeDdl.Items.Add(
                        new ListItem()
                        {
                            Text = type.Name,
                            Value = type.Id.ToString()
                        });
                }
            }



        }


        protected void SaveTypeDdl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SaveTypeDdl.SelectedValue == "1")
            {
                LocationDetails.Visible = true;
                WhDdl_SelectedIndexChanged(sender, e);
            }
            else
            {
                LocationDetails.Visible = false;
            }
        }

        protected void WhDdl_SelectedIndexChanged(object sender, EventArgs e)
        {

            ShDdl.Items.Clear();
            RowDdl.Items.Clear();
            BoxDdl.Items.Clear();

            int selectedWhId = int.Parse(WhDdl.SelectedValue);
            var selectedWh = context.Warehouses.Find(selectedWhId);
            WhCurrentCapL.Text = (selectedWh.CurrentCapacity).ToString();
            WhMaxCapL.Text = (selectedWh.MaxCapacity).ToString();

            var shList = context.Shelves.Where(s => s.WarehouseId == selectedWh.Id).ToList();
            foreach (var sh in shList)
            {
                ShDdl.Items.Add(
                    new ListItem()
                    {
                        Text = sh.Number,
                        Value = sh.Id.ToString()
                    });
            }
        }

        protected void ShDdl_SelectedIndexChanged(object sender, EventArgs e)
        {
            RowDdl.Items.Clear();
            BoxDdl.Items.Clear();

            int selectedShId = int.Parse(ShDdl.SelectedValue);
            var selectedSh = context.Shelves.Find(selectedShId);
            ShCurrentCapL.Text = (selectedSh.CurrentCapacity).ToString();
            ShMaxCapL.Text = (selectedSh.MaxCapacity).ToString();

            var rowList = context.Rows.Where(r => r.ShelfId == selectedSh.Id).ToList();
            foreach (var row in rowList)
            {
                RowDdl.Items.Add(
                    new ListItem()
                    {
                        Text = row.Number,
                        Value = row.Id.ToString()
                    });

            }
        }

        protected void RowDdl_SelectedIndexChanged(object sender, EventArgs e)
        {
            BoxDdl.Items.Clear();

            int selectedRowId = int.Parse(RowDdl.SelectedValue);
            var selectedRow = context.Rows.Find(selectedRowId);
            RowCurrentCapL.Text = (selectedRow.CurrentCapacity).ToString();
            RowMaxCapL.Text = (selectedRow.MaxCapacity).ToString();
            var boxList = context.Boxes.Where(b => b.RowId == selectedRow.Id).ToList();
            foreach (var box in boxList)
            {
                BoxDdl.Items.Add(
                new ListItem()
                {
                    Text = box.Number,
                    Value = box.Id.ToString()
                });

            }
        }

        protected void BoxDdl_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedBoxId = int.Parse(BoxDdl.SelectedValue);
            var selectedBox = context.Boxes.Find(selectedBoxId);
            BoxCurrentCapL.Text = (selectedBox.CurrentCapacity).ToString();
            BoxMaxCapL.Text = (selectedBox.MaxCapacity).ToString();
        }

        protected void SaveBtn_Click(object sender, EventArgs e)
        {
            var operatorId = HttpContext.Current.User.Identity.GetUserId();
            var operatoR = context.Users.Find(operatorId);
            int typeId = int.Parse(DocTypeDdl.SelectedValue);

            Document doc = new Document();
            doc.Name = DocNameTb.Text;
            doc.DocType = context.DocTypes.Find(typeId);
            doc.Description = DocDescrTb.Text;
            doc.Date = Calendar.SelectedDate;
            doc.IssuedTo = IssueToTb.Text;
            doc.IssuedById = IsueByDdl.SelectedValue;
            doc.DigitalPath = "none"; //TODO: SET DIGITAL PATH
            doc.BoxId = int.Parse(BoxDdl.SelectedValue);
            doc.SavedBy = operatoR.Name;
            doc.RequestStatusId = 1;

            context.Documents.Add(doc);
            context.SaveChanges();

            context.Documents.Find(doc.Id);

            Response.Redirect("/Default.aspx");
        }
    }

}



