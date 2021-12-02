using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMortarC : MonoBehaviour
{
    public float power = 5000f;
    public GameObject mortar, explosion;
    //Rigidbody rb;
    public Transform peluru;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnMortarBall());
    }

    // Update is called once per frame
    void Update()
    {

        //waktu di kllik, mortar nembak peluru
        if (Input.GetButton("Fire1"))
        {
           

        //    //munculkan spawnBall di mortar 
        //    GameObject spawnBall = Instantiate(mortar, peluru.position, peluru.rotation);
        //    spawnBall.GetComponent<Rigidbody>().velocity = peluru.transform.up * power;

        //    Destroy(Instantiate(explosion, peluru.position, peluru.rotation), 2);
        }
    }
    IEnumerator SpawnMortarBall()
    {
        GameObject spawnBall = Instantiate(mortar, peluru.position, Quaternion.identity);
        spawnBall.GetComponent<Rigidbody>().AddForce(peluru.transform.up * power);

        yield return new WaitForSeconds(Random.Range(2, 5));
        Destroy(spawnBall, 15);
        Destroy(Instantiate(explosion, peluru.position, peluru.rotation), 1);
        StartCoroutine(SpawnMortarBall());
    }
}
