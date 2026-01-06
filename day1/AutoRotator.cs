using UnityEngine;

// CLASS: DSA Unit 1
// DESCRIPTION: A simple script to rotate a GameObject continuously.
// USAGE: Attach this to any object (Sun, Planet, Moon) to make it spin.

public class AutoRotator : MonoBehaviour
{
    // [SerializeField] allows us to change this value in the Unity Inspector
    // while keeping the variable 'private' in code (Encapsulation).
    [Header("Rotation Settings")]
    [Tooltip("The speed of rotation in degrees per second (X, Y, Z)")]
    [SerializeField] private Vector3 rotationSpeed = new Vector3(0, 20, 0);

    // Update is called once per frame (e.g., 60 times a second)
    void Update()
    {
        // transform.Rotate takes a Vector3 (X, Y, Z)
        // We multiply by Time.deltaTime to make it "Frame Rate Independent"
        // This ensures it spins at the same speed on fast PCs and slow PCs.
        transform.Rotate(rotationSpeed * Time.deltaTime);
    }
}
