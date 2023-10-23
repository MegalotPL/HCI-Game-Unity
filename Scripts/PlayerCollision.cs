using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    private CameraShake cameraShake; // Reference to the CameraShake script

    private void Start()
    {
        cameraShake = Camera.main.GetComponent<CameraShake>(); // Get the CameraShake component from the main camera
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("CameraShakeTrigger"))
        {
            cameraShake.StartShake(); // Start shaking the camera
        }
    }
}