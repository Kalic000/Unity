using UnityEngine;

public class Gun : MonoBehaviour
{

    public float damage = 10f;
    public float range = 100f;

    public Camera fpsCam;

    private void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        print("alive");

        if (Input.GetMouseButtonDown(0)) 
        {
            Debug.Log("pressing");
            Shoot();
            
        }
    }


    void Shoot()
    {
        RaycastHit hit;
        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {
            Debug.Log(hit.transform.name);
        }
    }

}
