using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfRegi_V2
{
    class test
    {
        public test()
        {
            Console.WriteLine(  getJan2("9979",00590));
        }

        private string getJan2( string ccode2, int price2)
        {
            
           


                //Console.WriteLine(Session.product);
                //if (Session.product.goods_type == "1" || Session.product.Jancode.Substring(0, 3) == "978")
                
                    string ccode = ccode2.PadLeft(4, '0');
                    string price_tax_off = price2.ToString().PadLeft(5, '0');
                    //Console.WriteLine(ccode + "====" + price_tax_off);
                    int checkdigit = 0;
                    string first12 = "" + 192 + ccode + price_tax_off;
                   
                    int[] ch = { 1, 3 };
                    int n = ch.Length;
                    //Console.WriteLine(first12);
                    for (int i = 0; i < 12; i++)
                    {
                        checkdigit += (int)char.GetNumericValue(first12[i]) * ch[i % n];
                        //Console.WriteLine((int)char.GetNumericValue(first12[i]) + "====="+ch[i%n]);
                    }
                    checkdigit = checkdigit > 0 ? (10 - checkdigit % 10) : 0;
                    return "" + 192 + ccode + price_tax_off + checkdigit;
               
            
            return "";

        }

      
    }
}
