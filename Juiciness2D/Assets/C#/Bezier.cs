using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Den här koden gör så att en kub (i spelet en uggla) flyger i en båge från vänster till höger med hjälp av tre punkter som är placerade på skärmen.
//Morgan

public class Bezier : MonoBehaviour
{
    public LineRenderer lineRenderer;
    public Transform point0, point1, point2;

    private int numPoints = 50;
    private Vector3[] positions = new Vector3[50];

    [Range(0,1)]
    public float test = 0;

    // Start is called before the first frame update
    void Start()
    {
        lineRenderer.positionCount = numPoints;
    }

    // Update is called once per frame
    void Update()
    {
        test += Time.deltaTime;
        transform.position = CalculateQuadraticBezierPoint(test, point0.position, point1.position, point2.position);
       
    }
    private void Drawlinearcurve()
    {
        for (int i = 1; i < numPoints + 1; i++)
        {
            float t = i / (float)numPoints;
            positions[i - 1] = CalculateLinearBezierPoint(t, point0.position, point1.position);
        }
        lineRenderer.SetPositions(positions);

    }

    private Vector3 CalculateLinearBezierPoint(float t, Vector3 position1, Vector3 position2)
    {
        throw new NotImplementedException();
    }

    private void DrawQuadraticcurve()
    {
        for (int i = 1; i < numPoints + 1; i++)
        {
            float t = i / (float)numPoints;
            positions[i - 1] = CalculateQuadraticBezierPoint(t, point0.position, point1.position, point2.position);
        }
        lineRenderer.SetPositions(positions);

    }
    private Vector3 CalculateQuadraticBezierPoint(float t, Vector3 p0, Vector3 p1, Vector3 p2)
    {
        float u = 1 - t;
        float tt = t * t;
        float uu = u * u;
        Vector3 p = uu * p0;
        p += 2 * u * t * p1;
        p += tt * p2;
        return p;

    }
}




