using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moon : MonoBehaviour
{
    public PlanetBase orbitingPlanet;
    public float moonMass = 1f; 
    public float initialOrbitSpeed = 5f;
    public float stabilizingSpeed = 0.1f;

    private Vector3 moonVelocity;

    void Start()
    {
        if (orbitingPlanet == null)
        {
            Debug.LogError("Orbiting planet is not assigned!");
            return;
        }

        Vector3 directionToPlanet = (orbitingPlanet.transform.position - transform.position).normalized;
        moonVelocity = Vector3.Cross(directionToPlanet, Vector3.up) * initialOrbitSpeed;
    }

    void Update()
    {
        if (orbitingPlanet == null) return;

        Vector3 gravitationalForce = orbitingPlanet.CalculateGravitationalForce(transform, moonMass);

        moonVelocity += gravitationalForce * Time.deltaTime;

        Vector3 directionToPlanet = orbitingPlanet.transform.position - transform.position;
        Vector3 desiredVelocity = Vector3.Cross(directionToPlanet.normalized, Vector3.up) * moonVelocity.magnitude;
        moonVelocity = Vector3.Lerp(moonVelocity, desiredVelocity, Time.deltaTime * stabilizingSpeed);

        moonVelocity.y = 0;

        transform.position += moonVelocity * Time.deltaTime;
    }
}
