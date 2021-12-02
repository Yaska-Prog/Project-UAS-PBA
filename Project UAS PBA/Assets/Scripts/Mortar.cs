using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mortar : MonoBehaviour
{
    public GameObject ball;
    public Transform spawnPoint;
    public GameObject smoke;

    public Transform target;
    public float gravity = -10;
    public float hMax = 20;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Spawnball());
    }

    // Update is called once per frame
    void Update()
    {
          
    }

    Vector3 VelocityOfLaunch()
    {
        float displacementY = target.position.y - spawnPoint.position.y;
        Vector3 displacemenXZ = new Vector3(target.position.x - spawnPoint.position.x, 0, target.position.z - spawnPoint.position.z);

        Vector3 velocityY = Vector3.up * Mathf.Sqrt(-2 * gravity * hMax);
        Vector3 velocityXZ = displacemenXZ / (Mathf.Sqrt(-2 * gravity) + Mathf.Sqrt(2 * (displacementY - hMax) / gravity));
        Vector3 result = velocityXZ + velocityY;
        return result;
    }

    IEnumerator Spawnball()
    {
        GameObject createMortarball = Instantiate(ball, spawnPoint.position, Quaternion.identity);
        createMortarball.GetComponent<Rigidbody>().useGravity = true;
        createMortarball.GetComponent<Rigidbody>().velocity = VelocityOfLaunch();

        yield return new WaitForSeconds(Random.Range(3, 6));
        Destroy(createMortarball, 7);
        Destroy(Instantiate(smoke, spawnPoint.position, spawnPoint.rotation));
        StartCoroutine(Spawnball());

    }
}
