using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PlanetBase : MonoBehaviour
{
    public float gravitationalConstant; 
    public float planetMass; 

    public abstract void InitializePlanet();

    public Vector3 CalculateGravitationalForce(Transform moon, float moonMass)
    {
        Vector3 directionToMoon = moon.position - transform.position;
        float distance = directionToMoon.magnitude;

        distance = Mathf.Clamp(distance, 2f, 50f);

        float forceMagnitude = gravitationalConstant * (planetMass * moonMass) / (distance * distance);
        return directionToMoon.normalized * forceMagnitude;
    }
}
