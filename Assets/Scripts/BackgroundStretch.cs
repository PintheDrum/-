using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundStretch : MonoBehaviour
{
    public bool isAspectRatio;

    void Start()
    {
        var topRightCorner = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height));
        var worldSpaceWidth = topRightCorner.x * 2;
        var worldSpaceHeight = topRightCorner.y * 2;

        var spriteSize = GetComponent<SpriteRenderer>().bounds.size;

        var scaleFactorX = worldSpaceWidth / spriteSize.x;
        var sclaeFactorY = worldSpaceHeight / spriteSize.y;

        if (isAspectRatio)
        {
            if (scaleFactorX > sclaeFactorY)
                sclaeFactorY = scaleFactorX;
            else
                scaleFactorX = sclaeFactorY;
        }

        transform.localScale = new Vector2(scaleFactorX, sclaeFactorY);
    }
}
