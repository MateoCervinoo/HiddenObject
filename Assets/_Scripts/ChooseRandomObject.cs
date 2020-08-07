using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChooseRandomObject : MonoBehaviour
{
    public SpriteRenderer[] objectsToFind;

    int actualObject = 0;
    public float timeForHelp = 0f;
    public float sendHelp = 10f;

    void Update()
    {
        timeForHelp += Time.deltaTime;
        if(timeForHelp >= sendHelp)
        {
            int newPositionObject = Random.Range(0, objectsToFind.Length);
            actualObject = newPositionObject;
            objectsToFind[actualObject].color = new Color(0, 0, 0);
            Invoke("DeactiveHelp", 2);
            timeForHelp = 0;
        }
    }

    void DeactiveHelp()
    {
        objectsToFind[actualObject].color = new Color(255, 255, 255);
    }
}
