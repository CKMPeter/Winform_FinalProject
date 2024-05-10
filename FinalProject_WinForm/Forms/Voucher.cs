using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject_WinForm.Forms
{
    public partial class Voucher : Form
    {
        DBConnection conn =new DBConnection();
        public Voucher()
        {
            InitializeComponent();
        }
        public void Voucher_Load(object sender, EventArgs e)
        {
            string sqlstr = "Select * from VoucherView";
            dgvVoucher.DataSource = conn.Voucher(sqlstr, "add");
        }
    }
}
