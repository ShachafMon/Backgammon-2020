using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets
{
    public static class TriangleFactory
    {
        public static Triangle CreateTriangle()
        {
            return new Triangle();
        }

        public static Triangle CreateTriangle(TriangleStartingData data)
        {
            Triangle res = new Triangle();
            for (int i = 0; i < data.Count; i++)
            {
                res.CheckerManagers.Push(CheckerFactory.CreateChecker(data.Color));
            }
            res.CurrentColorOwner = data.Color;
            return res;

        }
    }
}
