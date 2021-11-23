using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMortarC : MonoBehaviour
{
    public GameObject mortar, explode;
    public Transform spawnPoint;
    public int shootPower = 2000;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

        //waktu di kllik, mortar nembak peluru
        if (Input.GetButtonDown("Fire1"))
        {
            //Instantiate(mortar, spawnPoint.position, Quaternion.identity);
        }
    }
    IEnumerator SpawnMortarBall()
    {
        GameObject ammo = Instantiate(mortar, spawnPoint.position, Quaternion.identity);
        ammo.GetComponent<Rigidbody>().AddForce(transform.up * shootPower * 2);

        yield return new WaitForSeconds(Random.Range(2, 5));
        Destroy(ammo, 2);
        Destroy(Instantiate(explode, spawnPoint.position, spawnPoint.rotation), -1);
        StartCoroutine(SpawnMortarBall());
    }
}
