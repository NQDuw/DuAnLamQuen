using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DuAnLamQuen
{
    public partial class MinhHoa : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {

                ddlNganh.Items.Add(new ListItem("Công Nghệ Thông Tin", "01"));
                ddlNganh.Items.Add(new ListItem("Kế Toán", "02"));
                ddlNganh.Items.Add(new ListItem("Xây Dựng", "03"));
            }
        }

        protected void btnGui_Click(object sender, EventArgs e)
        {
            string nganhchon = ddlNganh.SelectedItem.Text; //Lấy thông tin ngành người dùng chọn
            lbKetqua.Text = "Bạn đã chọn ngành: " + nganhchon + "</br>";//Gửi thông báo kqua về client
        }
    }
}