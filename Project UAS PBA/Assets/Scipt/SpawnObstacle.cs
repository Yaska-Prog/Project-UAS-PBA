using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObstacle : MonoBehaviour
{
    public GameObject obstacle;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnBatu());
    }

    // Update is called once per frame
    void Update()
    {

    }
    IEnumerator SpawnBatu() //Untuk menampilkan obstacle
	{
        Instantiate(obstacle, transform.position, Quaternion.identity);
        yield return new WaitForSeconds(1);
        StartCoroutine(SpawnBatu());
	}
}
