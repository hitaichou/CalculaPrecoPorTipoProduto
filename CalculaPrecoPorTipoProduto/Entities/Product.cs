using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace CalculaPrecoPorTipoProduto.Entities
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        private string _dsTag;

        //CONSTRUTORES
        public Product()
        {
        }
        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }
        //MÉTODOS
        public virtual string PriceTag() //usando virtual para permitir derivação (sobrescrita) do método
        {
            _dsTag = Name + " $ " + Price.ToString("F2", CultureInfo.InvariantCulture);
            return _dsTag;
        }

    }
}
