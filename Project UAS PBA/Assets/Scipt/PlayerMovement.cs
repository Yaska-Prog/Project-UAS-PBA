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
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        player.position += Vector3.forward * moveVertical * 0.05f;
        player.velocity = Vector3.right * moveHorizontal * speed;
        Hadap.localEulerAngles = new Vector3(0, moveHorizontal * 90, 0);
    }
}
