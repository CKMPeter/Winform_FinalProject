﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject_WinForm
{
    public class Items
    {
        private string itemId;
        private string itemName;
        private string itemDescription;
        private int itemQuantity;
        private int itemPrice;
        private int itemOldPrice;
        private string userName;
        private string[] itemImage = new string[3];
        private int itemQuanlity;
        private DateTime itemYear;
        private int itemRating;
        private string itemCatogory;

        public string ItemId { get { return itemId; } set { itemId = value; } }
        public string ItemName { get { return itemName; } set { itemName = value; } }
        public string ItemDescription { get { return itemDescription; } set { itemDescription = value; } }
        public int ItemQuantity { get { return itemQuantity; } set { itemQuantity = value; } }
        public int ItemPrice { get { return itemPrice; } set { itemPrice = value; } }
        public string UserName { get { return userName; } set { userName = value; } }
        public string[] ItemImage { get { return itemImage; } set { itemImage = value; } }
        public int ItemQuality { get { return itemQuanlity; } set { itemQuanlity = value; } }
        public DateTime ItemYear { get { return itemYear; } set { itemYear = value; } }
        public int ItemOldPrice { get { return itemOldPrice; } set { itemOldPrice = value; } }
        public int ItemRating { get { return itemRating; } set { itemRating = value; } }
        public string ItemCatagory { get { return itemCatogory; } set { itemCatogory = value; } }   
        public Items(string itemName, string itemDescription, int itemQuantity, int itemPrice, string userName, string[] itemImage, int itemQuanlity, DateTime itemYear, int itemOldPrice, int itemRating, string itemCatogory)
        {
            this.itemName = itemName;
            this.itemDescription = itemDescription;
            this.itemQuantity = itemQuantity;
            this.itemPrice = itemPrice;
            this.userName = userName;
            this.itemImage = itemImage;
            this.itemQuanlity = itemQuanlity;
            this.itemYear = itemYear;
            this.itemOldPrice = itemOldPrice;
            this.itemRating = itemRating;
            this.itemCatogory = itemCatogory;
        }
    }
}
