using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mars : PlanetBase
{
    private void Awake()
    {
        gravitationalConstant = 0.25f;
        planetMass = 500f;
    }

    public override void InitializePlanet()
    {
        Debug.Log("Mars initialized with custom gravitational properties.");
    }
}
