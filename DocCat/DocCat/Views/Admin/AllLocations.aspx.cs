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
    public partial class AllLocations : System.Web.UI.Page
    {
        DCDbContext context = new DCDbContext();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                var gridData = context.Warehouses
                      .Include(x => x.Shelves)
                                            .Select(x => new LocationsVM()
                                            {
                                                WhName = x.Name,
                                                CurrentCap = context.Documents.Where(y => y.Box.Row.Shelf.WarehouseId == x.Id).Count(),
                                                MaxCap = x.Shelves.FirstOrDefault().Rows.FirstOrDefault().Boxes.FirstOrDefault().MaxCapacity *
                                                x.Shelves.FirstOrDefault().Rows.FirstOrDefault().MaxCapacity *
                                                x.Shelves.FirstOrDefault().MaxCapacity *
                                                x.MaxCapacity,
                                            })
                      .ToList();
                LocationGV.DataSource = gridData;
                LocationGV.DataBind();
            }
        }
    }
}