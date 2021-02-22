using System;

namespace ClassLibrary
{
    public class clsStock
    {
        public clsStock()
        {
        }

        public int ItemId { get; set; }
        public string ItemName { get; set; }
        public bool ItemAvailable { get; set; }
        public DateTime DateItemAdded { get; set; }
        public decimal ItemSize { get; set; }
        public int StockLevel { get; set; }
    }
}