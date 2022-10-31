using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSwitcher : MonoBehaviour
{
    [SerializeField] int currentWeapon = 0;
    CameraZoom cameraZoom;
    void Start()
    {
        SetWeaponActive();
        cameraZoom = FindObjectOfType<CameraZoom>();
    }

    // Update is called once per frame
    void Update()
    {
       int previousWeapon = currentWeapon;
        ProcessKeyInput();
        ProcessScrollWheel();
        if (previousWeapon != currentWeapon)
        {
            SetWeaponActive();
        }

    }
    void ProcessKeyInput()
    {
        if(cameraZoom.zoomInToggle == false)
        {
            if (Input.GetKey(KeyCode.Alpha1))
            {
                currentWeapon = 0;
            }
            if (Input.GetKey(KeyCode.Alpha2))
            {
                currentWeapon = 1;
            }
            if (Input.GetKey(KeyCode.Alpha3))
            {
                currentWeapon = 2;
            }
        }
        
    }
    private void ProcessScrollWheel()
    {
        if(cameraZoom.zoomInToggle == false)
        {
            if (Input.GetAxis("Mouse ScrollWheel") < 0)
            {
                if (currentWeapon >= transform.childCount - 1)
                {
                    currentWeapon = 0;
                }
                else
                {
                    currentWeapon++;
                }
            }
            if (Input.GetAxis("Mouse ScrollWheel") > 0)
            {
                if (currentWeapon <= 0)
                {
                    currentWeapon = transform.childCount - 1;
                }
                else
                {
                    currentWeapon--;
                }
            }
        }
        
    }
    void SetWeaponActive()
    {
        int weaponIndex = 0;
        foreach(Transform weapon in transform)
        {
            if(weaponIndex == currentWeapon)
            {
                weapon.gameObject.SetActive(true);
            }
            else
            {
                weapon.gameObject.SetActive(false);
            }
            weaponIndex++;
        }
    }
}
