using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ListRightObjects : MonoBehaviour
{
    [SerializeField] public List<GameObject> listObjectsFind;
    public GameObject textYouWin;
        
    void Start()
    {
        listObjectsFind = new List<GameObject>();
        textYouWin.SetActive(false);
    }

    public void YouWin()
    {
        if (listObjectsFind.Count == 6)
        {
            Invoke("ActivateTextWin", 0.5f);
            //Debug.Log("Ganaste");
        }
    }

    void ActivateTextWin()
    {
        textYouWin.SetActive(true);
    }
}
