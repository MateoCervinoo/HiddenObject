using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightWrong : MonoBehaviour
{
    public SpriteRenderer tickSprite;
    public SpriteRenderer crossSprite;

    public bool spriteBool;

    float timeDelay = 0.5f;

    void Start()
    {
        StarTickCrossImage();    
    }

    public void StarTickCrossImage()
    {
        crossSprite.enabled = false;
        tickSprite.enabled = false;
        spriteBool = false;
    }
    public void ActivateTickImage()
    {
        if (spriteBool == false)
        {
            tickSprite.enabled = true;
            Invoke("DeactiveTickImage", timeDelay);
        }
    }

    public void ActivateCrossImage()
    {
        if (spriteBool == false) 
        {
            crossSprite.enabled = true;
            Invoke("DeactiveCrossImage", timeDelay);
        }
    }
    
    public void DeactiveTickImage()
    {
        tickSprite.enabled = false;
    }

    public void DeactiveCrossImage()
    {
        crossSprite.enabled = false;
    }
}
