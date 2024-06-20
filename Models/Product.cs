using CommunityToolkit.Maui.ImageSources;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtoDevMaui.Models
{
    public class Product
    {
        public string Id { get; set; }
        public string name { get; set; }
        public string image { get; set; }
        public decimal price { get; set; }

        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
