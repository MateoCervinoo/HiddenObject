using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.UI;

public class ObjectsNotFind : MonoBehaviour
{
    public GameObject objectNotFind;
    public RightWrong CrossImage;

    void OnMouseDown()
    {
        if(objectNotFind)
        { 
            CrossImage.ActivateCrossImage();
            //Debug.Log("Incorrect");
        }
    }
}
