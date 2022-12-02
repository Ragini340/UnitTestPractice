using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleUnitTestPractice
{
    public class PrimeService
    {
        public virtual bool IsPrime(int num)
        {
            for (int i = 2; i < num / 2; i++)
            {
                if (num % i== 0)
                {
                    return false;
                }

            }
            return true;
        }
    }



    public class NumberType
    {
        // PrimeService obj = new PrimeService();
        public String getNumberType(PrimeService obj, int num)
        {

            if (obj.IsPrime(num))
            {
                return "Prime";
            }
            else
            {
                return "Not Prime";
            }
        }

    }
}

    

