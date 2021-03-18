using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{

    public string[] staticDirect = { "Static N", "Static W", "Static S", "Static E" };
    private Animator animate;
    int lastDirection;

    void Awake()
    {
        animate = GetComponent<Animator>();
    }

    public void setDirection(Vector2 direction)
    {
        lastDirection = DirectionToIndex(direction, 4);
        animate.Play(staticDirect[lastDirection]);
    }

    private int DirectionToIndex(Vector2 direction, int slice)
    {
        Vector2 normDirection = direction.normalized;

        float step = 360 / slice;
        float halfstep = step / 2;

        float angle = Vector2.SignedAngle(Vector2.up, normDirection);
        angle += halfstep;

        if(angle < 0)
        {
            angle += 360;
        }

        float stepCount = angle / step;
        return Mathf.FloorToInt(stepCount);
    }
}
