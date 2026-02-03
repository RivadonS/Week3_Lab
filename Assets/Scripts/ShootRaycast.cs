using UnityEngine;

public class ShootRaycast : MonoBehaviour
{
    //shootPoint
    [SerializeField] Transform shootPoint;

    //variables for store vfxs
    [SerializeField] GameObject shootPointPrefab;
    [SerializeField] GameObject hitPointPrefab;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Shoot();
    }
    void Shoot()
    {
        RaycastHit hit;

        Debug.DrawRay(shootPoint.position, transform.forward * 30f, Color.blue);

        //if-statement
        if (Physics.Raycast(shootPoint.position, transform.forward, out hit, 100f))
        {
            Debug.DrawRay(shootPoint.position, transform.forward * hit.distance, Color.red);
            Debug.Log("Ray Hits " + hit.collider.name);
        }
    }
}
