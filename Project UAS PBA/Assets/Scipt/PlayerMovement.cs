using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerMovement : MonoBehaviour
{
    Rigidbody player;
    public float speed = 7;
    public Transform Hadap;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        PlayerMove();
    }
	private void Awake()
	{
        player = GetComponent<Rigidbody>();
	}
    void PlayerMove()
	{
        float move = Input.GetAxis("Horizontal");
        player.velocity = Vector3.right * move * speed;
        Hadap.localEulerAngles = new Vector3(0, move * 90, 0);

	}
}
