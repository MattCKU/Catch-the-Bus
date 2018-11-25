using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement
{
    public float Speed;
    public Movement(float speed)
    {
        Speed = speed;
    }

    public Vector3 Calculate(float h, float v, float deltaTime)
    {
        var x = h * Speed * deltaTime;
        var z = v * Speed * deltaTime;

        return new Vector3(x, 0, z);
    }
}