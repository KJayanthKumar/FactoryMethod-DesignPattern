﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method_Design_Pattern
{
    public class MoneyBackFactory : CreditCardFactory
    {
        protected override IcreditCard MakeProduct()
        {
            IcreditCard product = new MoneyBack();
            return product;
        }
    }
}
