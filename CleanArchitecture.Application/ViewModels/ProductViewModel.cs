using CleanArchitecture.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.ViewModels
{
    public class ProductViewModel
    {
        public IEnumerable<Product> Products { get; set; }
    }
}
