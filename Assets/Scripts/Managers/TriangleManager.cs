using Assets;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriangleManager : MonoBehaviour
{
     public Triangle Triangle { get; set; }
    private GameObject currentGameObject;
    public PlayerColor CurrentColor { get; set; }
    private const float Alpha = 1f;
    // Start is called before the first frame update

    private void Awake()
    {
        currentGameObject = gameObject;
        Debug.Log("Triangle " + gameObject.name + " Loaded");
    }

    private void Start()
    {
        GameBuilderService.instance.OnAllGameObjectReady += HandleGameObjectReady;
    }

    private void HandleGameObjectReady()
    {
        //var triangleID = int.Parse(gameObject.name.Substring(1));
        //Triangle = GameBuilderService.instance.GetTriangle(triangleID);
        //CurrentColor = GetTopChecker().Color;
        Debug.Log("Object ready");
        Debug.Log(GetTopChecker());
    }

    public void OnCheckerClicked()
    {
        Checker topChecker = GetTopChecker();


    }

    public Checker GetTopChecker()
    {
        return Triangle.CheckerManagers.Peek();
    }

    public void insertChecker(Checker checker)
    {
        Triangle.CheckerManagers.Push(checker);
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnMouseDown()
    {
        Debug.Log($"Triangle = {Triangle}");
    }


}
