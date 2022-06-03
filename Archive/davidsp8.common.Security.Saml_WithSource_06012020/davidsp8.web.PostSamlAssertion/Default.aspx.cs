using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace davidsp8.web.PostSamlAssertion {
    public partial class _Default : System.Web.UI.Page {
        

        protected void btnLogin_Click(object sender, EventArgs e) {
            this.Session.Add("SSO_Id", this.txtSSOID.Text);
            this.Session.Add("User_Id", this.txtUserId.Text);
            txtSSOID.Enabled = false;
            
            lnkSSO.Visible = true;
            btnLogin.Visible = false;
        }

        protected override void OnPreRender(EventArgs e) {
            base.OnPreRender(e);
            form1.FindControl("txtSSOID").Focus();
            if (!IsPostBack) {
                if (this.Session["SSO_Id"] != null) {
                    this.txtSSOID.Text = this.Session["SSO_Id"].ToString();
                    this.txtUserId.Text = this.Session["User_Id"].ToString();
                    txtSSOID.Enabled = false;
                    
                    lnkSSO.Visible = true;
                    btnLogin.Visible = false;
                }
            }

        }

        private void InitializeComponent() {
            this.Load += new System.EventHandler(this._Default_Load);

        }

        private void _Default_Load(object sender, EventArgs e) {
           
        }


    }
}
