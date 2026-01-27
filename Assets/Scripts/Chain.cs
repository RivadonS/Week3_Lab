using UnityEngine;

public class Chain : MonoBehaviour
{
    public float force;
    public Vector3 direction;
    public Rigidbody rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb.AddForce(direction * force, ForceMode.Impulse);
    }

    // Update is called once per frame
    void FixedUpdate()
    {

    }
}
