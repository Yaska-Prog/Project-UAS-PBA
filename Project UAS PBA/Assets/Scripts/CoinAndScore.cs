using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CoinAndScore : MonoBehaviour
{
    public int currentCoin, currentScore;
    public Text coinValueUI, scoreValueUI;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Coin"))
        {
            currentCoin += 1;
            currentScore += 20;
            coinValueUI.text = currentCoin.ToString();
            scoreValueUI.text = currentScore.ToString();
            Destroy(collision.collider.gameObject);

        }
    }
}
