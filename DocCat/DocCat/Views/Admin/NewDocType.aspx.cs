using DocCat.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DocCat.Views.Admin
{
    public partial class NewDocType : System.Web.UI.Page
    {
        DCDbContext context = new DCDbContext();
        protected void Page_Load(object sender, EventArgs e)
        {
            resultLbl.ForeColor= System.Drawing.Color.Red;
        }

        protected void SaveBtn_Click(object sender, EventArgs e)
        {
            if (context.DocTypes.Any(x => x.Name == DocTypeNameTb.Text.ToLower()) == false)
            {
                var type = new DocType();
                type.Name = DocTypeNameTb.Text;
                context.DocTypes.Add(type);
                context.SaveChanges();
                resultLbl.Visible = false;

            }
            else
            {
                resultLbl.Visible = true;
            }

        }

        protected void CancelBtn_Click(object sender, EventArgs e)
        {

        }
    }
}