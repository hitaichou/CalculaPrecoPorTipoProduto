using System;
using System.Collections.Generic;
using System.Text;

namespace CalculaPrecoPorTipoProduto.Entities
{
    class UsedProduct : Product //": Product" importando caracteristicas da classe Product
    {
        public DateTime ManufactureDate { get; set; }
        private string _dsTag;

        public UsedProduct()
        {
        }
        public UsedProduct(string name, double price, DateTime manufactureDate)
            :base(name, price)
        {
            ManufactureDate = manufactureDate;
        }

        public override string PriceTag()
        {            
            _dsTag = Name + " (used) $ " + Price + "(Manufacture date: " + ManufactureDate.ToString("dd/MM/yyyy") + ")";
            return _dsTag;
        }
    }
}
