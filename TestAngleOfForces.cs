using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using System.Xml.Serialization;

public class TestAngleOfForces
{
    
    [Test]
    public void TestAngleOfForcesSimplePasses45()
    {
        AngleOfForcesCalculator testAngleOfVectors = new AngleOfForcesCalculator();

        Vector3 force1 = new Vector3(1, 1, 0);
        Vector3 force2 = new Vector3(0, 1, 0);

        double result = testAngleOfVectors.AngleOfForces(force1, force2);
        Debug.Log("45 = " + result);
        Assert.AreEqual(45f, result);

    }

    [Test]
    public void TestAngleOfForcesSimplePasses60()
    {
        AngleOfForcesCalculator testAngleOfVectors = new AngleOfForcesCalculator();

        Vector3 force1 = new Vector3(1, 1, 0);
        Vector3 force2 = new Vector3(0, 1, 1);

        double result = testAngleOfVectors.AngleOfForces(force1, force2);
        
        Debug.Log("60 = " + result);
        Assert.AreEqual(60f, result);

    }

    [Test]
    public void TestAngleOfForcesSimplePasses90()
    {
        AngleOfForcesCalculator testAngleOfVectors = new AngleOfForcesCalculator();

        Vector3 force1 = new Vector3(0, 1, 0);
        Vector3 force2 = new Vector3(0, 0, 1);

        double result = testAngleOfVectors.AngleOfForces(force1, force2);
        Debug.Log("90 = " + result);
        Assert.AreEqual(90f, result);

    }
    
}
