using UnityEngine;

public class PullUp : MonoBehaviour
{

    [SerializeField] private float tension;
    [SerializeField] private float mass;
    [SerializeField] private float acc;

    Rigidbody rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        mass = rb.mass;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        tension =  mass * (-Physics.gravity.y + acc);
        rb.AddForce(Vector3.up * tension);
    }
}
