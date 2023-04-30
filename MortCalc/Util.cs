using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MortCalc
{
    internal class Util
    {
        public static List<string[]> Calculate(decimal Upb, decimal Rate, int Period, decimal Payment)
        {
            List<string[]> RetVal = new List<string[]>(Period);

            for (int i = 0; i < Period; ++i)
            {
                if (Upb == 0)
                {
                    return RetVal;
                }
                decimal InterestPayment = Upb * Rate;
                Upb += InterestPayment;
                decimal ActualPayment =
                    Upb > Payment ?
                    Payment :
                    Upb;
                Upb -= ActualPayment;
                decimal PrincipalPayment = ActualPayment - InterestPayment;
                string[] Row = new string[4];
                Row[0] = (i + 1).ToString();
                Row[1] = $"￥{Upb:n2}";
                Row[2] = $"￥{PrincipalPayment:n2}";
                Row[3] = $"￥{InterestPayment:n2}";
                RetVal.Add(Row);
            }
            return RetVal;
        }
    }
}
