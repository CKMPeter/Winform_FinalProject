using System;
using System.Collections.Generic;
using System.Drawing;
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
            string sqlStr = "SELECT * from CartView where IsDeleted = 0 and IsPay = 0";
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

        public void DeleteFromCart(User A, Items B, string reason)
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
            string sqlStr = string.Format($"EXECUTE DeletedCartItemProc @UserName = '{A.Name}', @ItemId = '{guid}', @CancelDisciption = '{reason}'");
            db.Execute(sqlStr, "deleted");
        }

        public void PayForCart(User A, string itemId)
        {
            Guid guid;
            bool success = Guid.TryParse(itemId.ToString(), out guid);

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
            string sqlStr = string.Format($"EXECUTE PayCartProc @UserName = '{A.Name}', @ItemId = '{guid}'");
            db.Execute(sqlStr, "pay");
        }
    }
}
