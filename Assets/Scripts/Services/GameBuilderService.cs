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
    public Triangle[] Triangles { get; set; }
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
        Debug.Log("GameBuilderReady");
        instance = this;
        //MakeSingleton();
        Triangles = new Triangle[24];
    }

    private void Start()
    {
        Debug.Log("Game Builder Service");
        var startGameData = new StartGameDataService();
        for (int i = 0; i < 24; i++)
        {
            var data = startGameData.triangleStartingDataById[i];
            if (data != null)
                Triangles[i] = TriangleFactory.CreateTriangle(data);
            else
                Triangles[i] = TriangleFactory.CreateTriangle();
        }
        GameIsReadyToPlay();
    }


    private void GameIsReadyToPlay()
    {
        OnAllGameObjectReady?.Invoke();
    }
}
