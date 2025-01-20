using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlanetNameUI : MonoBehaviour
{
    public Camera mainCamera; 
    public Transform earthCameraPosition; 
    public Transform marsCameraPosition; 
    public Transform jupiterCameraPosition; 

    public TMP_Text uiText;

    private void Update()
    {
        float distanceToEarth = Vector3.Distance(mainCamera.transform.position, earthCameraPosition.position);
        float distanceToMars = Vector3.Distance(mainCamera.transform.position, marsCameraPosition.position);
        float distanceToJupiter = Vector3.Distance(mainCamera.transform.position, jupiterCameraPosition.position);

        if (distanceToEarth < distanceToMars && distanceToEarth < distanceToJupiter)
        {
            uiText.text = "Current Planet: Earth";
        }
        else if (distanceToMars < distanceToEarth && distanceToMars < distanceToJupiter)
        {
            uiText.text = "Current Planet: Mars";
        }
        else if (distanceToJupiter < distanceToEarth && distanceToJupiter < distanceToMars)
        {
            uiText.text = "Current Planet: Jupiter";
        }
    }
}
