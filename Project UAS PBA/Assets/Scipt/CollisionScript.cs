using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionScript : MonoBehaviour
{
    public Health healthNow;
    public int currentHealth;
    public int maxHealth = 100;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthNow.SetHealth(maxHealth);
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter(Collision collision)
    {
		if (collision.collider.CompareTag("Sphere"))
		{
			DamageForce(10);
			Destroy(collision.collider.gameObject);
		}

	}
    public void DamageForce(int damage)
    {
		currentHealth -= damage;
		healthNow.SetHealth(currentHealth);
	}
}