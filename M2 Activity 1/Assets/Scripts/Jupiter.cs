using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jupiter : PlanetBase
{
    private void Awake()
    {
        gravitationalConstant = 2f;
        planetMass = 6000f;
    }

    public override void InitializePlanet()
    {
        Debug.Log("Mars initialized with custom gravitational properties.");
    }
}
