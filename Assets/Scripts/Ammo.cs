using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Ammo : MonoBehaviour
{
    [SerializeField] AmmoSlot[] ammoSlot;
    [SerializeField] TextMeshProUGUI pistolAmout;
    [SerializeField] TextMeshProUGUI shotGunAmout;
    [SerializeField] TextMeshProUGUI riffleAmout;

    [System.Serializable]
    private class AmmoSlot
    {
        public AmmoType ammoType;
        public int ammoAmount;
    }


    public int GetCurrentAmmo(AmmoType ammoType)
    {
        return GetAmmoSlot(ammoType).ammoAmount;  
    }
    public void ReduceCurrentAmmo(AmmoType ammoType)
    {
        GetAmmoSlot(ammoType).ammoAmount--;
    }
    public void IncreaseCurrentAmmo(AmmoType ammoType, int ammoAmount)
    {
        GetAmmoSlot(ammoType).ammoAmount += ammoAmount;
    }
    private AmmoSlot GetAmmoSlot(AmmoType ammoType)
    {
        foreach(AmmoSlot slot in ammoSlot)
        {
            if(slot.ammoType == ammoType)
            {
                return slot;
            }
        }
        return null;
    }
    private void Update()
    {
        pistolAmout.text = ammoSlot[2].ammoAmount.ToString();
        shotGunAmout.text = ammoSlot[1].ammoAmount.ToString();
        riffleAmout.text = ammoSlot[0].ammoAmount.ToString();
    }
}
