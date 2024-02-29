using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DuAnLamQuen
{
    public partial class ThongTinCaNhan : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            //Code Khởi tạo dữ liệu cho các điều khiển
            if (!Page.IsPostBack)
            {
                //Khởi tạo  cho ddlTrinhDo
                ddlTrinhDo.Items.Add(new ListItem("Trung Cấp"));
                ddlTrinhDo.Items.Add(new ListItem("Cao Đẳng"));
                ddlTrinhDo.Items.Add(new ListItem("Đại Học"));


                //Khởi tạo chp lstNgheNghiep
                lstNgheNghiep.Items.Add(new ListItem("Công Nhân"));
                lstNgheNghiep.Items.Add(new ListItem("Công An"));
                lstNgheNghiep.Items.Add(new ListItem("Sinh Viên"));

                //Khởi tạo chp chkListSoThich
                chkListSoThich.Items.Add(new ListItem("Mua sắm"));
                chkListSoThich.Items.Add(new ListItem("Xem phim"));
                chkListSoThich.Items.Add(new ListItem("Du lịch"));
                chkListSoThich.Items.Add(new ListItem("Thể thao"));
            }
        }

        protected void btGui_Click(object sender, EventArgs e)
        {
            string kq = "";
            //B1.Thu thập thông tin
            kq += "<ul>";
            kq += "<br>";
            kq += "<h2>Thông tin đăng kí của bạn</h2>";
            kq += "<ul>";
            //Lấy thông tin Họ Tên
            kq += $"<li>Họ Tên: {txtHoTen.Text}</li> ";
            kq += string.Format("<li>Ngày Sinh: {0}</li> ", txtNgaySinh.Text);
            if (rdNam.Checked)
            {
                kq += $"<li> Giới Tính: {rdNam.Text} </li>";
            }
            else
            {
                kq += $"<li> Giới Tính: {rdNu.Text} </li>";
            }

            kq += $"<li> Trình độ: {ddlTrinhDo.SelectedItem.Text} </li>";
            kq += $"<li> Nghề Nghiệp: {lstNgheNghiep.SelectedItem.Text} </li>";

            //Xử lý lấy thông tin sở thích
            string sothich = "";
            foreach (ListItem x in chkListSoThich.Items)
            {
                if (x.Selected)
                {
                    sothich += x.Text + ";";
                }
            }

            kq += $"<li>Sở Thích: {sothich}</li>";
            //Xử lý upload hình (nếu có)
            if (FHinh.HasFile)
            {
                //Lấy về đường dẫn tuyệt đối của thư mục uploads trên server
                string path = Server.MapPath("~/Uploads");
                //Sao chép tập tin từ người dùng lên server
                FHinh.SaveAs(path + "/" + FHinh.FileName);
                kq += $"<li>Ảnh:  <img src='Uploads/{FHinh.FileName}'></li>";
            }


            kq += "<ul>";
            //B2.Trả Kết quả về client
            lbketqua.Text = kq;
        }
    }
}