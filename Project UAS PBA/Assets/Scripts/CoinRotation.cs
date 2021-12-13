using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinRotation : MonoBehaviour
{
    public int rotation;
    public Transform mortarAmmo;
    public Transform cannonAmmo;

    // Start is called before the first frame update
    void Start()
    {
        rotation = 3;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, rotation);
        Physics.IgnoreCollision(mortarAmmo.GetComponent<Collider>(), GetComponent<Collider>());
        Physics.IgnoreCollision(cannonAmmo.GetComponent<Collider>(), GetComponent<Collider>());
    }
}
