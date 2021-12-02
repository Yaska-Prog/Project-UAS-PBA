using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCannonball : MonoBehaviour
{
    public GameObject cannonballPrefab;
    public Transform spawnPoint;
    public int shootPower = 100;
    public GameObject Explode;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Spawnball());
        //rb.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {

            //GameObject createCannonball = Instantiate(cannonballPrefab, spawnPoint.position, spawnPoint.rotation);
            ////createCannonball.GetComponent<Rigidbody>().AddForce(transform.forward * 1);
            //createCannonball.GetComponent<Rigidbody>().velocity = spawnPoint.transform.up * 10 * Time.deltaTime;
        }
    }

    IEnumerator Spawnball()
    {
        //Instantiate(cannonballPrefab, spawnPoint.position, spawnPoint.rotation);
        //work with addforce
        GameObject createCannonball = Instantiate(cannonballPrefab, spawnPoint.position, Quaternion.identity);
        createCannonball.GetComponent<Rigidbody>().AddForce(transform.up * shootPower * 2);

        yield return new WaitForSeconds(Random.Range(2, 5));
        Destroy(createCannonball, 3);
        Destroy(Instantiate(Explode, spawnPoint.position, spawnPoint.rotation), 1);
        StartCoroutine(Spawnball());

    }
}
