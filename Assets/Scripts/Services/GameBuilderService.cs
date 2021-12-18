using Assets;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Timers;
using UnityEngine;
using UnityEngine.EventSystems;

public class GameBuilderService : MonoBehaviour
{
    /// Build all managers in the game, then raise event to finish create game, all GameObject (mananger) is getting thier object by ID
    /// 

    public static GameBuilderService instance;
    public event Action OnAllGameObjectReady;
    public Triangle[] Triangles { get; set; } = new Triangle[24];
    //public void MakeSingleton()
    //{
    //    if (instance == null)
    //        Destroy(gameObject);
    //    else
    //    {
    //        instance = this;
    //        DontDestroyOnLoad(gameObject);
    //    }
    //}

    internal Triangle GetTriangle(int id)
    {
        return Triangles[id];
    }

    private void Awake()
    {
        //MakeSingleton();
        instance = this;
        Debug.Log("Game Builder is awake");
    }

    private void Start()
    {
        Debug.Log("Creating array");
        var startGameData = new StartGameDataService();
        for (int i = 0; i < 24; i++)
        {
            Debug.Log(i);
            TriangleStartingData data;
            startGameData.triangleStartingDataById.TryGetValue("T" + i, out data);
            if (data != null)
            {
                var tri = TriangleFactory.CreateTriangle(data);
                Triangles[i] = tri;
            }
            else
            {
                var tria = TriangleFactory.CreateTriangle();
                Triangles[i] = tria;
            }
        }
        Debug.Log("Array created");

        GameIsReadyToPlay();
    }


    private void GameIsReadyToPlay()
    {
        OnAllGameObjectReady?.Invoke();
    }
}
