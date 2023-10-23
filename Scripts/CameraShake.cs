using UnityEngine;

public class CameraShake : MonoBehaviour
{
    public float shakeDuration = 2f; // Duration of the camera shake
    public float shakeMagnitude = 0.7f; // Intensity of the camera shake

    private Transform cameraTransform; // Reference to the main camera's transform
    private Vector3 originalPosition; // Original position of the camera
    private float currentShakeDuration = 0f; // Current duration of the camera shake

    private void Start()
    {
        cameraTransform = Camera.main.transform; // Get the main camera's transform
        originalPosition = cameraTransform.localPosition; // Store the original camera position
    }

    public void StartShake()
    {
        currentShakeDuration = shakeDuration;
    }

    private void Update()
    {
        if (currentShakeDuration > 0)
        {
            // Generate a random position within a sphere and multiply it by the shake magnitude
            Vector3 shakePosition = Random.insideUnitSphere * shakeMagnitude;

            // Update the camera position
            cameraTransform.localPosition = originalPosition + shakePosition;

            currentShakeDuration -= Time.deltaTime;
        }
        else
        {
            currentShakeDuration = 0f;
            cameraTransform.localPosition = originalPosition; // Reset the camera position
        }
    }
}