using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject_WinForm
{
    public class OrderedItem
    {
        int itemQuantity;
        string itemName;
        string itemId;
        string userName;
        int itemPrice;

        public int ItemQuantity { get { return itemQuantity; } set {  itemQuantity = value; } }
        public string ItemName { get {  return itemName; } set { itemName = value; } }
        public int ItemPrice { get {  return itemPrice; } set { itemPrice = value; } }
        public string ItemId { get { return itemId; } set { itemId = value; } }
        public string UserName { get { return userName; } set { userName = value; } }

        public OrderedItem(int itemQuantity, string itemName, string itemId, string userName, int itemPrice) 
        { 
            this.itemQuantity = itemQuantity;
            this.itemName = itemName;  
            this.itemId = itemId;
            this.userName = userName;
            this.itemPrice = itemPrice;
        }
    }
}
