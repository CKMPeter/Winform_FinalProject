using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject_WinForm
{
    public class CartDAO
    {
        DBConnection db = new DBConnection();
        public List<OrderedItem> LoadCartInfo()
        {
            string sqlStr = "SELECT * from CartView";
            return db.LoadUserCart(sqlStr, "load");
        }

        public void AddToCart(User A, Items B, int quantity)
        {
            Guid guid;
            bool success = Guid.TryParse(B.ItemId.ToString(), out guid);

            if (success)
            {
                // GUID parsing was successful, you can use 'guid' variable here
                Console.WriteLine("GUID: " + guid);
            }
            else
            {
                // Parsing failed, handle error
                Console.WriteLine("Invalid GUID format.");
            }
            string sqlStr = string.Format($"EXECUTE AddToCartProc @UserName = '{A.Name}', @ItemId = '{guid}', @ItemQuantity = '{quantity}'");
            db.Execute(sqlStr, "add");
        }
    }
}
