using Assets;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardManager : MonoBehaviour
{
    public Board Board { get; private set; }
    // Start is called before the first frame update
    private GameObject currentGameObject;
    private void Awake()
    {
        currentGameObject = gameObject;
        Debug.Log("Board Loaded");
        
    }

    private void Start()
    {
        GameBuilderService.instance.OnAllGameObjectReady += HandleGameObjectReady;
    }

    private void HandleGameObjectReady()
    {
        Debug.Log("Handled from Board");
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    private void MoveChecker(Triangle triangle, int steps)
    {
        
    }

    private void OnMouseDown()
    {
        Debug.Log($"Board = {Board}");
    }


}
