using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] float playerHealth = 100.0f;
    [SerializeField] TextMeshProUGUI playerHealthText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        DisplayPlayerHealth();
        
    }
    public void TakeDamage(float damage)
    {
        playerHealth -= damage;
        if(playerHealth <= 0)
        {
            GetComponent<DeathHandler>().HandleDeath();
        }

    }
    void DisplayPlayerHealth()
    {
        playerHealthText.text = playerHealth.ToString();
        if(playerHealth < 60 && playerHealth > 20)
        {
            playerHealthText.color = Color.yellow;
        }
        else if(playerHealth <= 20)
        {
            playerHealthText.color = Color.red;
        }
    }
}
