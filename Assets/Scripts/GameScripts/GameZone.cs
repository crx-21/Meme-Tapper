using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameZone : MonoBehaviour
{
    public float padding = 0.5f;

    public float Left { get; private set; }
    public float Right { get; private set; }
    public float Top { get; private set; }
    public float Bottom { get; private set; }

    void Update()
    {
        if (Camera.main == null) return;

        float height = Camera.main.orthographicSize * 2f;
        float width = height * Camera.main.aspect;

        Left = -width / 2f + padding;
        Right = width / 2f - padding;
        Top = height / 2f - padding;
        Bottom = -height / 2f + padding;
    }

    public Vector2 GetRandomPosition()
    {
        return new Vector2(
            Random.Range(Left, Right),
            Random.Range(Bottom, Top)
        );
    }
}
