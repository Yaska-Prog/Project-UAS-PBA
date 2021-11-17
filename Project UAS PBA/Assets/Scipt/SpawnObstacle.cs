using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObstacle : MonoBehaviour
{
    public GameObject Sphere;
    public GameObject spawnPoint;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnBatu());
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(Random.Range(35.85f, 44.22f), 3.8f, 14.62f);
    }
    IEnumerator SpawnBatu() //Untuk menampilkan obstacle
	{
        Instantiate(Sphere, transform.position, Quaternion.identity);
        yield return new WaitForSeconds(1);
        StartCoroutine(SpawnBatu());
	}
}
