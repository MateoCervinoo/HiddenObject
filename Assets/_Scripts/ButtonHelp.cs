using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonHelp : MonoBehaviour
{
    public GameObject panelOfHelp;

    public void ActivateButtonHelp()
    {
        panelOfHelp.SetActive(true);
    }

    public void DeactiveButtonHelp()
    {   
        panelOfHelp.SetActive(false);   
    }
}
