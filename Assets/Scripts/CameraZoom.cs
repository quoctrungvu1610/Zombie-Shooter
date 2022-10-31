using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class CameraZoom : MonoBehaviour
{
    [SerializeField] Camera fpsCamera;
    [SerializeField] RigidbodyFirstPersonController fpsController;

    [SerializeField] float zoomedOutFOV = 60f;
    [SerializeField] float zoomedInFOV = 20f;
    [SerializeField] float zoomInSensitivity = .5f;
    [SerializeField] float zoomOutSensitivity = 2f;
    public bool zoomInToggle = false;

    //private void OnDisable()
    //{
    //    ZoomOut();
    //}
    void Update()
    {
        
        if (Input.GetMouseButtonDown(1))
        {
            if (zoomInToggle == false)
            {
                ZoomIn();

            }
            else
            {

                ZoomOut();
            }
        } 
    }
    void ZoomIn()
    {
        zoomInToggle = true;
        fpsCamera.fieldOfView = zoomedInFOV;
        fpsController.mouseLook.XSensitivity = zoomInSensitivity;
        fpsController.mouseLook.YSensitivity = zoomInSensitivity;
    }
    void ZoomOut()
    {
        zoomInToggle = false;
        fpsCamera.fieldOfView = zoomedOutFOV;
        fpsController.mouseLook.XSensitivity = zoomOutSensitivity;
        fpsController.mouseLook.YSensitivity = zoomOutSensitivity;
    }

}
