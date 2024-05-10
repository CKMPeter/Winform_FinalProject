using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace FinalProject_WinForm
{
    public class VoucherDao
    {
        DBConnection conn = new DBConnection();
        public void addVoucher(string ItemId, int Rating)
        {
            string sqlStr = $"insert into Voucher(ItemId, VoucherValue) values('{ItemId}','{Rating}')";
            conn.Execute(sqlStr, "add");
        }
    }
}
