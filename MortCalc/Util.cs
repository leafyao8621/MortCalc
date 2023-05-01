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
                decimal ActualInterestPayment =
                    ActualPayment > InterestPayment ?
                    InterestPayment :
                    ActualPayment;
                Upb -= ActualPayment;
                decimal PrincipalPayment = ActualPayment - ActualInterestPayment;
                string[] Row = new string[4];
                Row[0] = (i + 1).ToString();
                Row[1] = $"￥{Upb:n2}";
                Row[2] = $"￥{PrincipalPayment:n2}";
                Row[3] = $"￥{ActualInterestPayment:n2}";
                RetVal.Add(Row);
            }
            return RetVal;
        }
        public static List<decimal[]> ReadFile(string FileName)
        {
            bool success = true;
            List<decimal[]> RetVal = new List<decimal[]>();
            using (StreamReader Reader = new StreamReader(FileName))
            {
                while (!Reader.EndOfStream)
                {
                    decimal[] row = new decimal[2];
                    string Line = Reader.ReadLine();
                    if (Line[0] == '\n')
                    {
                        break;
                    }
                    string[] values = Line.Split(',');
                    if (values.Length != 2)
                    {
                        success = false;
                        break;
                    }
                    try
                    {
                        row[0] = decimal.Parse(values[0]);
                        row[1] = decimal.Parse(values[1]);
                        RetVal.Add(row);
                    }
                    catch (Exception exc)
                    {
                        MessageBox.Show($"文件读取错误\n{exc}");
                    }
                }
            }
            if (!success)
            {
                MessageBox.Show("文件读取错误");
            }
            return RetVal;
        }
        public static List<string[]> CalculateVariable(decimal Upb, int NumAccrual, List<decimal[]> Payments)
        {
            if (Payments == null || Payments.Count() == 0)
            {
                return null;
            }
            int Period = Payments.Count();
            List<string[]> RetVal = new List<string[]>(Period);
            int i = 0;
            foreach (decimal[] row in Payments)
            {
                ++i;
                decimal Rate = row[0] / 100 / NumAccrual;
                decimal Payment = row[1];
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
                decimal ActualInterestPayment =
                    ActualPayment > InterestPayment ?
                    InterestPayment :
                    ActualPayment;
                Upb -= ActualPayment;
                decimal PrincipalPayment = ActualPayment - ActualInterestPayment;
                string[] Row = new string[4];
                Row[0] = i.ToString();
                Row[1] = $"￥{Upb:n2}";
                Row[2] = $"￥{PrincipalPayment:n2}";
                Row[3] = $"￥{ActualInterestPayment:n2}";
                RetVal.Add(Row);
            }
            return RetVal;
        }
    }
}
