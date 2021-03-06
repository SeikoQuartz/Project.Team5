using Project.Managers;
using Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project
{
    public partial class Login : System.Web.UI.Page
    {
        private AccountManager _mgr = new AccountManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (this._mgr.IsLogined())
            {
                this.plcUserInfo.Visible = true;
                this.plcLogin.Visible = false;
                MemberAccount account = this._mgr.GetCurrentUser();
                this.ltlAccount.Text = account.Account;
            }
            else
            {
                this.plcLogin.Visible = true;
                this.plcUserInfo.Visible = false;
            }
        }
        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string account = this.txtAccount.Text.Trim();
            string pwd = this.txtPassword.Text.Trim();
            if (this._mgr.TryLogin(account, pwd)) //沒寫true or false =為true的省略寫法
            {
                Response.Redirect("~/BackAdmin/AdminOnly.aspx");
               // Response.Redirect(Request.RawUrl);

            }
            if (this._mgr.TryLogin2(account, pwd)) //沒寫true or false =為true的省略寫法
            {
                Response.Redirect("~/MainPage.aspx");
                // Response.Redirect(Request.RawUrl);

            }
            else
            {
                this.ltlMessage.Text = "登入失敗";
            }
        }
    }
}