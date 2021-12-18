using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets
{
    public class StartGameDataService
    {
        public Dictionary<int, TriangleStartingData> triangleStartingDataById = new Dictionary<int, TriangleStartingData>();
        public StartGameDataService()
        {
            triangleStartingDataById.Add(0, new TriangleStartingData { Color = PlayerColor.black, Count = 2 });
            triangleStartingDataById.Add(5, new TriangleStartingData { Color = PlayerColor.white, Count = 5 });
            triangleStartingDataById.Add(7, new TriangleStartingData { Color = PlayerColor.white, Count = 3 });
            triangleStartingDataById.Add(11, new TriangleStartingData { Color = PlayerColor.black, Count = 5 });
            triangleStartingDataById.Add(12, new TriangleStartingData { Color = PlayerColor.white, Count = 5 });
            triangleStartingDataById.Add(16, new TriangleStartingData { Color = PlayerColor.black, Count = 3 });
            triangleStartingDataById.Add(18, new TriangleStartingData { Color = PlayerColor.black, Count = 5 });
            triangleStartingDataById.Add(23, new TriangleStartingData { Color = PlayerColor.white, Count = 2 });
        }


    }
}
