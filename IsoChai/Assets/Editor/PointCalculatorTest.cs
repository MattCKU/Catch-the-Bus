using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NUnit.Framework;

public class PointCalculator
{
    public int CalculateTotalPoints(int capturedCats, int caughtBus, int ranIntoProfessor, int multiplicator)
    {
        int points = 0;

        points += capturedCats * 100;
        points += caughtBus * 100;
        points -= ranIntoProfessor * 100;
        if(ranIntoProfessor > 10)
        {
            multiplicator = 1;
        }
        points *= multiplicator;

        return points;
    }
}

public class PointCalculatorTests
{
    [Test]
    public void CalculateTotalPoints_Test()
    {
        var pointCalculator = new PointCalculator();
        var capturedCats = 1;
        var caughtBus = 10;
        var ranIntoProfessor = 5;
        var multiplicator = 2;
        var expectedPoints = ((1 * 100) + (100 * 10) - (5 * 100)) * 2;

        //Action
        var points = pointCalculator.CalculateTotalPoints(capturedCats, caughtBus, ranIntoProfessor, multiplicator);

        //Assert
        Assert.That(points, Is.EqualTo(expectedPoints));
	}
}
