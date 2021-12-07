using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinRotation : MonoBehaviour
{
    public int rotation;
    // Start is called before the first frame update
    void Start()
    {
        rotation = 3;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, rotation);
    }
}
