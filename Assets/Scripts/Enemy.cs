using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] int health = 50;
    [SerializeField] int damage = 10;

    public void TakeDamage()
    {
        health -= damage;
        Debug.Log($"{name} took {damage} damage!");

        if ( health <= 0 )
            Destroy(this.gameObject, 1f);
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
