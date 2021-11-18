using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerMovement : MonoBehaviour
{
    Rigidbody player;
    public float speed = 7;
    public Transform Hadap;
    public Health healthNow;
    public int maxHealth = 100;
    public int currentHealth;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthNow.SetHealth(maxHealth);
    }
    private void Update()
    {
        //jika player kena batu, maka darah berkurang
    }
    public void DamageForce(int damage)
    {
        currentHealth -= damage;
        healthNow.SetHealth(currentHealth);
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
