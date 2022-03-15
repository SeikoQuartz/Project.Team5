using Project.Managers;
using Project.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Project.Models;


namespace Project.BackAdmin
{
    public partial class AdminOnly : System.Web.UI.Page
    {

        private AccountManager _mgr = new AccountManager();

        protected void Page_Load(object sender, EventArgs e)
        {
            MemberAccount account = this._mgr.GetCurrentUser();
            this.ltlAccount.Text = account.Account;
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            this._mgr.Logout();
            Response.Redirect("~/Login.aspx");
        }



        protected void btnDelete_Click(object sender, EventArgs e)
        {

        }

        protected void btnWrite_Click(object sender, EventArgs e)
        {
            


        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminOnly.aspx");
        }

        protected void btnCreate_Click(object sender, EventArgs e)
        {

        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {

        }

        //protected void btnSearch_Click(object sender, EventArgs e)
        //{
        //    string Keyword = this.txtKeyword.Text;
        //    List<MemberAccount> KeywordSendback = _mgr.GetAccountList(Keyword);
        //    this.GridView1.DataSource = KeywordSendback;
        //    this.GridView1.DataBind();






        //}
    }
}