using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets
{
    public class CheckerFactory
    {
        public static Checker CreateChecker(PlayerColor color)
        {
            return new Checker(color);
        }
    }
}
