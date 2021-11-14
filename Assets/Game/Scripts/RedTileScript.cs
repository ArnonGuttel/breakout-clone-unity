using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedTileScript : MonoBehaviour
{
    private int _hitCounter = 0;
    public SpriteRenderer sp;
    public Sprite newSprite;
    
    private void OnCollisionEnter2D()
    {
        if (_hitCounter == 0)
        {
            sp.sprite = newSprite;
            _hitCounter++;
        }
        else
        {
            GridManager.RemoveTile(gameObject);
        }
    }
}
