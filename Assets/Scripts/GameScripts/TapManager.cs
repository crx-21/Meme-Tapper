using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TapManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 worldPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Collider2D col = Physics2D.OverlapPoint(worldPoint);

            if (col != null)
            {
                Ball doge = col.GetComponent<Ball>();
                if (doge != null)
                {
                    doge.Hit();
                }
            }
        }
    }
}
