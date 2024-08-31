using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharsConsole
{
    internal class Console15LinqDataSet
    {
        public void checkScore()
        {
            int[] intScore = { 62, 80, 91, 51, 75, 76, 32 };
            var score = from hgScore in intScore
                        where hgScore >= 60
                        orderby hgScore ascending
                        select hgScore;
            Console.WriteLine("Pass: ");
            foreach (var v in score)
            {
                Console.WriteLine(v);
            }
        }
    }
}
