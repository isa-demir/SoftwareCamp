using System;
using System.Collections.Generic;
using System.Text;

namespace Mehods
{
    class SepetManager
    {
        public void Add(Product product)
        {
            Console.WriteLine("Başarılı! {0} sepete eklendi.\nStok : {1}",product.ProductName, product.InStock--);
        }
        
    }
}
