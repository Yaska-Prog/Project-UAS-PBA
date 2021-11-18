using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public Slider fill;

    public void MaxHealth(int health)
    {
        fill.maxValue = health;
        fill.value = health;
    }
    public void SetHealth(int health)
    {
        fill.value = health;
    }

   
}
