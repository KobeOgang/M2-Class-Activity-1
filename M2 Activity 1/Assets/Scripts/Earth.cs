using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Earth : PlanetBase
{
    private void Awake()
    {
        gravitationalConstant = 0.5f;
        planetMass = 1000f;
    }

    public override void InitializePlanet()
    {
        Debug.Log("Earth initialized with custom gravitational properties.");
    }
}
