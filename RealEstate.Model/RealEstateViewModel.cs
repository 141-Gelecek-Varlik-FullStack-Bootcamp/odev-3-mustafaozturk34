using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate.Model
{
    public class RealEstateViewModel
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Type { get; set; }
        public decimal SquareMeters { get; set; }
        public int Iuser { get; set; }
    }
}
