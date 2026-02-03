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

            if (Input.GetMouseButtonDown(0))
            {
                //spawn particle at shoot point
                GameObject muzzle = Instantiate(shootPointPrefab, shootPoint.position, Quaternion.identity);
                muzzle.transform.LookAt(hit.point);

                //spawn particle at hit point
                GameObject hitEffect = Instantiate(hitPointPrefab, hit.point, Quaternion.LookRotation(hit.normal));

                Destroy(muzzle, 1);
                Destroy(hitEffect, 1);

                if (hit.collider.name == "Enemy")
                {
                    Enemy enemy = hit.collider.GetComponent<Enemy>();
                    if (enemy != null)
                    {
                        enemy.TakeDamage();
                    }
                }
            }
        }
    }
}
