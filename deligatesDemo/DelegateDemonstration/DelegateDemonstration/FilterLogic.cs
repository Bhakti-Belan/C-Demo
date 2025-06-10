using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemonstration
{
    internal class FilterLogic
    {
        private FilterProduct fp;
        public FilterLogic(FilterProduct fp)
        {
            this.fp = fp;
        }
        public void FilteredProduct(Products[]p)
        {
            fp(p);
        }
    }
}
