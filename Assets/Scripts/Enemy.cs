using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Enemy : MonoBehaviour
{
    [Header("Enemy Stats")]
    [SerializeField] int health = 50;
    [SerializeField] int damage = 10;

    [Header("Physics Settings")]
    [SerializeField] float torqueAmount = 10f;

    private Rigidbody rb;
    public void TakeDamage()
    {
        health -= damage;
        Debug.Log($"{name} took {damage} damage!");

        if ( health <= 0 )
            Destroy(this.gameObject, 1f);

        Vector3 randomDirection = Random.insideUnitSphere; 

        rb.AddTorque(randomDirection * torqueAmount, ForceMode.Impulse);
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
