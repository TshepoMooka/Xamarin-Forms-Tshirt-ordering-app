
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
namespace TshirtApp
{
    public class Info
    {
        [PrimaryKey, SQLite.AutoIncrement]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfOrder { get; set; }
        public string TShirtColor { get; set; }
        public string ShippingAddress { get; set; }
        public string TShirtSize { get; set; }
    }
}