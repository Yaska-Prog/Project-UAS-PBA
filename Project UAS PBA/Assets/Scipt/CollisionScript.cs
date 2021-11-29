using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class CollisionScript : MonoBehaviour
{
    public Health healthNow;
    public int currentHealth;
    public int maxHealth = 100;
    public GameObject gameOverUI;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthNow.SetHealth(maxHealth);
        gameOverUI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (currentHealth <= 0)
        {
            gameOverUI.SetActive(true);
            Time.timeScale = 0f;
            if (Input.GetKeyDown(KeyCode.R)) //Untuk restart
            {
                Scene scene = SceneManager.GetActiveScene();
                SceneManager.LoadScene(scene.name);
                Time.timeScale = 1f;
            }
            if (Input.GetKeyDown(KeyCode.M)) //Untuk kembali ke main menu
            {
                SceneManager.LoadScene("MainMenu");
            }
        }
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
    public void TransitionToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void ResetScene()
	{
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}