using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets
{
    public class Triangle
    {
        public int Id { get; set; }
        public Stack<Checker> CheckerManagers { get; set; } = new Stack<Checker>();
        public PlayerColor? CurrentColorOwner { get; set; }
    }
}
