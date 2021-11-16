using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HancurkanBatu : MonoBehaviour
{
    public GameObject obstacle;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Penghancur());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public IEnumerator Penghancur()
	{
        yield return new WaitForSeconds(5);
        Destroy(obstacle);
	}
}
