using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform[] cameraPositions; 
    private int currentIndex = 0;       
    public float transitionSpeed = 5f; 

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            if (currentIndex < cameraPositions.Length - 1)
                currentIndex++;
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            if (currentIndex > 0)
                currentIndex--;
        }

        transform.position = Vector3.Lerp(transform.position, cameraPositions[currentIndex].position, Time.deltaTime * transitionSpeed);
        transform.rotation = Quaternion.Slerp(transform.rotation, cameraPositions[currentIndex].rotation, Time.deltaTime * transitionSpeed);
    }
}
