using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float Speed;
    public Movement Movement;

    void Start()
    {
        Movement = new Movement(Speed);
    }

    void Update()
    {
        transform.position += Movement.Calculate(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"), Time.deltaTime);
    }
}

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

using NUnity.Framework;
namespace Tests.Editor
{
    public class MovementTests
    {
        [Test]
        public void Moves_Along_X()
        {
            Assert.AreEqual(1, new Movement(1).Calculate(1, 0, 1).x, 0.1f);
        }
        [Test]
        public void Moves_Along_Z()
        {
            Assert.AreEqual(1, new Movement(1).Calculate(1, 0, 1).z, 0.1f);
        }
    }
}