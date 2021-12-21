using Assets;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriangleManager : MonoBehaviour
{
    public Triangle Triangle { get; set; }
    private GameObject currentGameObject;
    public PlayerColor ? CurrentColor { get; set; }
    private const float Alpha = 1f;
    // Start is called before the first frame update

    private void Awake()
    {
        currentGameObject = gameObject;
        Debug.Log("Triangle Manager is awake");

        GameBuilderService.instance.OnAllGameObjectReady += HandleGameObjectReady;

    }


    private void HandleGameObjectReady()
    {
        var triangleID = int.Parse(gameObject.name.Substring(1));
        Triangle = GameBuilderService.instance.GetTriangle(triangleID);
        Triangle.Id = triangleID;
        CurrentColor = Triangle.CurrentColorOwner;
        Debug.Log(Triangle.Id);
    }

    public void OnCheckerClicked()
    {
        Checker topChecker = this.Triangle.CheckerManagers.Peek();


    }

    public Checker GetMoovedChecker()
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
