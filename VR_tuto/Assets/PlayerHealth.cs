using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    private int maxHealth = 100;

    private float currentHealth;

    public healthbar healthbar;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthbar.SetMaxhealth(maxHealth);
    }
    

    public void takeDammage(float dammage)
    {
        currentHealth -= dammage;
        healthbar.SetHealthBar(currentHealth);
    }

    private void OnTriggerStay(Collider other)
    {
        takeDammage(0.1f);
    }
}