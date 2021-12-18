using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets
{
    public class StartGameDataService
    {
        public Dictionary<string, TriangleStartingData> triangleStartingDataById = new Dictionary<string, TriangleStartingData>();
        public StartGameDataService()
        {
            triangleStartingDataById.Add("T0", new TriangleStartingData { Color = PlayerColor.Black, Count = 2 });
            triangleStartingDataById.Add("T5", new TriangleStartingData { Color = PlayerColor.White, Count = 5 });
            triangleStartingDataById.Add("T7", new TriangleStartingData { Color = PlayerColor.White, Count = 3 });
            triangleStartingDataById.Add("T11", new TriangleStartingData { Color = PlayerColor.Black, Count = 5 });
            triangleStartingDataById.Add("T12", new TriangleStartingData { Color = PlayerColor.White, Count = 5 });
            triangleStartingDataById.Add("T16", new TriangleStartingData { Color = PlayerColor.Black, Count = 3 });
            triangleStartingDataById.Add("T18", new TriangleStartingData { Color = PlayerColor.Black, Count = 5 });
            triangleStartingDataById.Add("T23", new TriangleStartingData { Color = PlayerColor.White, Count = 2 });
            Debug.Log(triangleStartingDataById["T23"]);
        }
       

    }
}
