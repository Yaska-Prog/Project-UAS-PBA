using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCoin : MonoBehaviour
{
    public GameObject coin;
    //public Transform spawnPoint;

    public int power = 100;
    public float rotationSpeed = 100f;

    //List<float> xPosition = new List<float>();
    float[] xPos = new float[2];
    
    // Start is called before the first frame update
    void Start()
    {
        //xPos[0] = 82.09f;
        //xPos[1] = 99.5f;
        //xPosition = [82.09f, 99.5f];
        StartCoroutine(SpawnCoins());
    }

    // Update is called once per frame
    void Update()
    {
        //System.Random rd = new System.Random();
        //float idx = rd.Next(xPos.Length);
        //transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
        //transform.position = new Vector3(idx, 4.5f, 301.73f);

        //transform.Rotate(150, 0, 0);
    }

    IEnumerator SpawnCoins()
    {
        GameObject createCoin = Instantiate(coin, transform.position, Quaternion.identity);
        createCoin.GetComponent<Rigidbody>().AddForce(transform.up * power * 2);
        //createCoin.GetComponent<Transform>().Rotate(0, 0, rotationSpeed);
        createCoin.GetComponent<Transform>().Rotate(90, 0, 0);


        yield return new WaitForSeconds(Random.Range(3, 5));
        Destroy(createCoin, 3);
        StartCoroutine(SpawnCoins());
    }
}
