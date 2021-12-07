using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerLevel2 : MonoBehaviour
{
    float currentTime;
    public Text curentTimeValue;

    // Start is called before the first frame update
    void Start()
    {
        currentTime = 0;
    }

    // Update is called once per frame
    void Update()
    {
        currentTime += Time.deltaTime;
        System.TimeSpan time = System.TimeSpan.FromSeconds(currentTime);
        curentTimeValue.text = time.ToString(@"mm\:ss\:fff");
    }
}
