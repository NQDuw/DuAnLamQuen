﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DuAnLamQuen
{
    public partial class TinhToan : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btncong_Click(object sender, EventArgs e)
        {
            double soThuNhat = Convert.ToDouble(txtso1.Text);
            double soThuHai = Convert.ToDouble(txtso2.Text);

            double Kq = soThuNhat + soThuHai;
            txtkq.Text = Kq.ToString();
        }

        protected void btntru_Click(object sender, EventArgs e)
        {
            double soThuNhat = Convert.ToDouble(txtso1.Text);
            double soThuHai = Convert.ToDouble(txtso2.Text);

            double Kq = soThuNhat - soThuHai;
            txtkq.Text = Kq.ToString();
        }

        protected void btnnhan_Click(object sender, EventArgs e)
        {
            double soThuNhat = Convert.ToDouble(txtso1.Text);
            double soThuHai = Convert.ToDouble(txtso2.Text);

            double Kq = soThuNhat * soThuHai;
            txtkq.Text = Kq.ToString();
        }

        protected void bntchia_Click(object sender, EventArgs e)
        {
            double soThuNhat = Convert.ToDouble(txtso1.Text);
            double soThuHai = Convert.ToDouble(txtso2.Text);

            double Kq = soThuNhat / soThuHai;
            txtkq.Text = Kq.ToString(); 
        }
    }
}