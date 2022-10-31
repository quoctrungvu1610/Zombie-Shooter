using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class AmmoPickup : MonoBehaviour
{
    [SerializeField] int ammoAmount = 5;
    [SerializeField] AmmoType ammoType;
    [SerializeField] TextMeshProUGUI pickUpText;


    // Start is called before the first frame update
    void Start()
    {
        
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.tag == "Player")
        {
            pickUpText.gameObject.SetActive(true);
            if (Input.GetKey(KeyCode.F))
            {
                PickupBullet();
            }   
        }
        
    }
    private void OnTriggerExit(Collider other)
    {
        pickUpText.gameObject.SetActive(false);
    }
    void PickupBullet()
    {
        
        FindObjectOfType<Ammo>().IncreaseCurrentAmmo(ammoType, ammoAmount);
        pickUpText.gameObject.SetActive(false);
        Destroy(gameObject);
    }
}
