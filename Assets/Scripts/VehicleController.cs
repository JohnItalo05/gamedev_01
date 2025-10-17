using UnityEngine;

public class VehicleController : MonoBehaviour
{
    public float speed = 15.0f; // meters per second

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Move forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
