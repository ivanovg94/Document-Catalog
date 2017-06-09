using System;
using System.Linq;
using System.Web;
using System.Web.UI;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Owin;
using DocCat.Models;
using System.Web.UI.WebControls;

namespace DocCat.Account
{
    public partial class Register : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                UserTypeDdl.Items.Clear();
                UserTypeDdl.Items.Add(new ListItem
                {
                    Text = "Оператор",
                    Value = "operator"
                });

                UserTypeDdl.Items.Add(new ListItem
                {
                    Text = "Клиент",
                    Value = "customer"
                });
                UserTypeDdl.SelectedIndex = 1;
            }

            if (UserTypeDdl.SelectedValue == "operator")
            {
                NameLbl.Text = "Име на оператор";
                customerInfoDiv.Visible = false;
            }
            else if (UserTypeDdl.SelectedValue == "customer")
            {
                NameLbl.Text = "Име на организация";
                customerInfoDiv.Visible = true;

            }

        }

        protected void CreateUser_Click(object sender, EventArgs e)
        {
            var manager = Context.GetOwinContext().GetUserManager<ApplicationUserManager>();
            var signInManager = Context.GetOwinContext().Get<ApplicationSignInManager>();
            var user = new ApplicationUser()
            {
                UserName = Email.Text,
                Email = Email.Text,
                Name = NameTb.Text,
                Bulstat=BulstatTb.Text,
                Address=AddressTb.Text,
                Phone=PhoneTb.Text
            };
            IdentityResult result = manager.Create(user, Password.Text);

            var roleresult = manager.AddToRole(user.Id, UserTypeDdl.SelectedValue);


            if (result.Succeeded)
            {
                // For more information on how to enable account confirmation and password reset please visit https://go.microsoft.com/fwlink/?LinkID=320771
                //string code = manager.GenerateEmailConfirmationToken(user.Id);
                //string callbackUrl = IdentityHelper.GetUserConfirmationRedirectUrl(code, user.Id, Request);
                //manager.SendEmail(user.Id, "Confirm your account", "Please confirm your account by clicking <a href=\"" + callbackUrl + "\">here</a>.");

                //signInManager.SignIn(user, isPersistent: false, rememberBrowser: false);
                //IdentityHelper.RedirectToReturnUrl(Request.QueryString["ReturnUrl"], Response);

                Response.Redirect("/Default.aspx");
            }
            else
            {
                ErrorMessage.Text = result.Errors.FirstOrDefault();
            }
        }
    }
}