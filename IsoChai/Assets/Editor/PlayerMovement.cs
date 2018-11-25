using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NUnit.Framework;

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