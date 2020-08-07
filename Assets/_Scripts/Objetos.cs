using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Objetos : MonoBehaviour
{
    public GameObject objetoCorrecto;
    public GameObject objetoIncorrecto;

    void Start()
    {
 
    }

    void OnMouseDown()
    {
        if (objetoCorrecto)
        {
            objetoCorrecto.gameObject.SetActive(false);
            Debug.Log("Bien");
        }
        if(objetoIncorrecto)
        {
            Debug.Log("Mal");
        }      
    }
}
