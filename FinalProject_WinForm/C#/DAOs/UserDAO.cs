using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace FinalProject_WinForm
{
    
    public class UserDAO
    {
        DBConnection db = new DBConnection();

        public List<User> LoadUInfo()
        {
            string sqlStr = "SELECT * from UserInfo";
            return db.LoadUser(sqlStr,"load");
        }

        public void AddUser(User A)
        {
            string sqlStr = string.Format("INSERT INTO UserInfo(UserName, UserPassword, UserGender, UserAddress, UserEmail, UserImage, UserRating, UserVisa, UserPaypal) " +
                "VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}')", A.Name, A.Password, A.Gender, A.Address, A.Email, A.Avatar, A.Rating, A.Visa, A.Paypal);
            db.Execute(sqlStr, "add");
        }
        
        public void UpdateUser(User A)
        {
            string sqlStr = string.Format($"UPDATE UserInfo SET UserPassword = '{A.Password}', UserEmail = '{A.Email}', UserAddress = '{A.Address}', UserGender = '{A.Gender}', UserImage = '{A.Avatar}', UserRating = '{A.Rating}', UserVisa = '{A.Visa}', UserPaypal = '{A.Paypal}' WHERE UserName = '{A.Name}'");
            db.Execute(sqlStr, "update");
        }
    }
}
