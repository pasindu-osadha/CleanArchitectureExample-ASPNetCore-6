using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Domain.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string PName { get; set; }
        public int Price { get; set; }
        public string PDescription { get; set; }
    }
}
