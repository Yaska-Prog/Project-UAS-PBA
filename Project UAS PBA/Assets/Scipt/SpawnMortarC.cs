using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMortarC : MonoBehaviour
{
    public float power = 5f;
    public GameObject mortar, explosion;
    //Rigidbody rb;
    public Transform peluru;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

        //waktu di kllik, mortar nembak peluru
        if (Input.GetButton("Fire1"))
        {
            //munculkan spawnBall di mortar 
            GameObject spawnBall = Instantiate(mortar, peluru.position, peluru.rotation);
            spawnBall.GetComponent<Rigidbody>().velocity = peluru.transform.up * power;

            Destroy(Instantiate(explosion, peluru.position, peluru.rotation), 2);
        }
    }
    //IEnumerator SpawnMortarBall()
    //{
    //    GameObject ammo = Instantiate(mortar, spawnPoint.position, Quaternion.identity);
    //    ammo.GetComponent<Rigidbody>().AddForce(transform.up * shootPower * 2);

    //    yield return new WaitForSeconds(Random.Range(2, 5));
    //    Destroy(ammo, 2);
    //    Destroy(Instantiate(explode, spawnPoint.position, spawnPoint.rotation), -1);
    //    StartCoroutine(SpawnMortarBall());
    //}
}
