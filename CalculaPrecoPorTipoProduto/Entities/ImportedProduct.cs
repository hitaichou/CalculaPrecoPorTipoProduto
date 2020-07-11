using System;
using System.Collections.Generic;
using System.Text;

namespace CalculaPrecoPorTipoProduto.Entities
{
    class ImportedProduct : Product //": Product" importa as características da classe Product
    {
        public double CustomFee { get; set; }
        private double _vlTotal;
        private double _vlPrice;
        private string _dsTag;

        //CONSTRUTORES
        public ImportedProduct()
        {
        }
        public ImportedProduct(string name, double price, double customfee)
            :base(name, price) //usando propriedades da superclasse
        {
            CustomFee = customfee;
        }

        //METODOS
        //sobrescrevo a tag de Product
        public override string PriceTag()
        {
            _dsTag = "Tablet $ " + TotalPrice() + "(Customs fee: " + CustomFee + ")";
            return _dsTag;
        }
        public double TotalPrice()
        {
            //somo o preço lançado na classe Product com CustomFee
            _vlTotal = Price + CustomFee; 
            return _vlTotal;
        }
    }
}
