using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AngleOfForcesCalculator : MonoBehaviour
{
    [SerializeField] public Vector3[] _force1;
    [SerializeField] public Vector3[] _force2;
    [SerializeField] List<double> resultAngles = new List<double>(3);

    private double angle;


    // Start is called before the first frame update
    void Start()
    {

        Method();
    }

    private void StartCalculations()
    {
        for (int i = 0; i < _force1.Length; i++)
        {
            double result = AngleOfForces(_force1[i], _force2[i]);
            resultAngles[i] = result;
        }

        foreach (DataEntry data in XMLManager.ins.dataDB.list)
        {
            SaveValues(data);
        }

    }

    public double AngleOfForces(Vector3 force1, Vector3 force2)
    {
        float cosAngle = Vector3.Dot(force1, force2) / (force1.magnitude * force2.magnitude);

        angle = Mathf.Acos(cosAngle) * Mathf.Rad2Deg;

        Debug.Log("Force1= " +force1 + " Force2=" + force2 + " result=" + System.Math.Round(angle, 2) + " degree");

        return System.Math.Round(angle, 2);
        
    }


    public void LoadValues(DataEntry data)
    {
        _force1 = data.force1;
        _force2 = data.force2;
    }


    public void SaveValues(DataEntry data)
    {
        data.resultAngles = resultAngles;
    }


    public void Method()
    {
        foreach (DataEntry data in XMLManager.ins.dataDB.list)
        {
            LoadValues(data);
        }


        StartCalculations();
    }
}
