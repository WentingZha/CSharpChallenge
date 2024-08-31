using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharsConsole
{
    internal class Console16Exception
    {
        public void tryCatch()
        {
            try
            {
                object obj = null;
                int N = (int)obj;
            }
            catch (Exception ex)
            {
                //NullReferenceException
                Console.WriteLine("Catch exception：" + ex);
            }
        }

        public void divideByZero(String a, String b)
        {

            int int1;
            int int2;
            int num;
            try
            {
                int1 = int.Parse(a);
                int2 = int.Parse(b);
                if (int2 == 0)
                {
                    throw new DivideByZeroException();
                }
                num = int1 / int2;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Catch exception：" + ex.Message);

            }

        }

        public void finallyExpression()
        {
            string str = "Technique";
            object obj = str;
            try
            {
                int i = (int)obj;
            }
            catch (InvalidCastException)
            {
                Console.WriteLine("InvalidCastException");
            }
            finally
            { 
                Console.WriteLine("End");
            }
        }
    }
}
