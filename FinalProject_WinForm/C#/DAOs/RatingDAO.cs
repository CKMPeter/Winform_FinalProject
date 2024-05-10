using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject_WinForm
{
    public class RatingDAO
    {
        DBConnection db = new DBConnection();
        public void addRating(string UserName, string ItemId, int Rating)
        {
            string sqlStr = $"insert into Rating(UserName, ItemId, Rating) values('{UserName}', '{ItemId}','{Rating}')";
            db.Execute(sqlStr, "add");
        }
    }
}
