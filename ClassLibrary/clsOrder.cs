using System;

namespace ClassLibrary
{
    public class clsOrder
    {
        public bool Active { get; set; }
        public DateTime DateAdded { get; set; }
        public int Rating { get; set; }
        public string Description { get; set; }
        public decimal TotalPrice { get; set; }
    }
}