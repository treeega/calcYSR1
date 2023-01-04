using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public class Calculate
    {
       
        public string DoCalculate(int count, double numo, double displayf)// арифметический метод
        {
            double numt;
            switch (count)
            {

                case 1:
                    numt = numo + displayf;
                    return numt.ToString();

                case 2:
                    numt = numo - displayf;
                    return numt.ToString();

                case 3:
                    numt = numo * displayf;
                    return numt.ToString();

                case 4:
                    if (displayf == 0)
                    {
                        
                        return "0";
                    }
                    else
                    {
                        numt = Math.Round(numo / displayf,0);
                        return numt.ToString();
                    }

                default:
                    return "0";


            }
           



        }
       public string backer(string display)// убирает один символ
        {
            int leng = display.Length - 1;
            string tx = display;
            display = "";
            for (int i = 0; i < leng; i++)
            {
                display = display + tx[i];
            }
            return display;
        }
    }
}
