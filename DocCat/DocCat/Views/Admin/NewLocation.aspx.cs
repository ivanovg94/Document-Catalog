using DocCat.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DocCat.Views.Admin
{
    public partial class NewLocation : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SaveBtn_Click(object sender, EventArgs e)
        {
            var context = new DCDbContext();

            if (context.Warehouses.Any(w=>w.Name==WarehouseNameTb.Text))
            {

                String URL = "Page2.aspx?Exception=" + 409;
                Response.Redirect(URL);
                return;
                
            }
            var wh = new Warehouse();
            wh.Name = WarehouseNameTb.Text;
            wh.MaxCapacity = int.Parse(WhCapTb.Text);
            wh.CurrentCapacity = 0;

            context.Warehouses.Add(wh);
            context.SaveChanges();

            var currentWh = context.Warehouses.FirstOrDefault(x => x.Name == WarehouseNameTb.Text);

            int count = 1;
            string shName = "";
            string rowName = "";
            string boxName = "";
            for (int i = 1; i <= wh.MaxCapacity; i++)
            {
                var shelf = new Shelf();
                shName = string.Concat("wh", currentWh.Id, "sh", count);
                shelf.Number = shName;
                shelf.CurrentCapacity = 0;
                shelf.MaxCapacity = int.Parse(ShCapTb.Text);
                shelf.WarehouseId = currentWh.Id;

                context.Shelves.Add(shelf);
                context.SaveChanges();


                var currentShelf = context.Shelves.FirstOrDefault(s => s.Number == shName);

                for (int j = 1; j <= currentShelf.MaxCapacity; j++)
                {
                    var row = new Row();
                    rowName = string.Concat(currentShelf.Number, "r", j);
                    row.Number = rowName;
                    row.CurrentCapacity = 0;
                    row.MaxCapacity = int.Parse(RowCapTb.Text);
                    row.ShelfId = currentShelf.Id;

                    context.Rows.Add(row);
                    context.SaveChanges();

                    var currentRow = context.Rows.FirstOrDefault(r => r.Number == rowName);

                    for (int k = 1; k <= currentRow.MaxCapacity; k++)
                    {
                        var box = new Box();
                        boxName = string.Concat(currentRow.Number, "b", k);
                        box.Number = boxName;
                        box.CurrentCapacity = 0;
                        box.MaxCapacity = int.Parse(BoxCapTb.Text);
                        box.RowId = currentRow.Id;
                        context.Boxes.Add(box);
                        context.SaveChanges();

                    }
                }
                count++;
            }
            Response.Redirect("/Default.aspx");   
        }

    }
}