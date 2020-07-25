using NewsCompany;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Store
{
     public class Seller
    {
        private float moneyEarned;

        public void SellNewspaper(Newspaper newspaper)
        {
            moneyEarned += newspaper.GetPrice();
        }
        public override string ToString()
        {
            return $"[Money earned]: {moneyEarned}";
        }

    }
}
