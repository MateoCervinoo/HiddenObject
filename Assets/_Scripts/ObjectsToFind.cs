using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectsToFind : MonoBehaviour
{
    public GameObject objectToFind;
    public RightWrong tickImage;
    public ListRightObjects listObjects;

    void OnMouseDown()
    {
        if (objectToFind)
        {
            objectToFind.SetActive(false);
            //Debug.Log("Correct");
            tickImage.ActivateTickImage();
            listObjects.listObjectsFind.Add(objectToFind);
            listObjects.YouWin();
        }
    } 
}
