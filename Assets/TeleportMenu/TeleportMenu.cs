using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class TeleportMenu : MonoBehaviour
{
    private bool acquiredControllers = false;
    private List<InputDevice> devices = new List<InputDevice>();
    private List<InputDevice> rightControllerList = new List<InputDevice>();
    private InputDevice rightController;

    public GameObject xrOrigin;
    public GameObject mainCamera;
    public GameObject RightController;
    public GameObject HousePanel;

    public float timeBetweenPresses = 0.19f;
    private float timestamp;


    //public List<Vector3> teleportLocations;

    //public int currentTeleportLocation = 0;
    public List<Vector3> groundLocations;
    private int currentGroundLocation = 0;

    public List<Vector3> skyLocations;
    private int currentSkyLocation = 0;

    private bool panelActive = false;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("teleport menu starting up");
        timestamp = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        
        if( !acquiredControllers)
        {
            Debug.Log("attempting to assign controllers");
            InputDevices.GetDevices(devices);
            if ( devices.Count > 1)
            {
                InputDeviceCharacteristics rightControllerCharacteristics = InputDeviceCharacteristics.Right | InputDeviceCharacteristics.Controller;
                InputDevices.GetDevicesWithCharacteristics(rightControllerCharacteristics, rightControllerList);
                rightController = rightControllerList[0];

                acquiredControllers = true;
            }
            
        }
        if( acquiredControllers )
        {

           

            if ( Time.time > timestamp + timeBetweenPresses)
            {
                rightController.TryGetFeatureValue(CommonUsages.primaryButton, out bool primaryButtonValue);
                if (primaryButtonValue)
                {
                    //displayMenu = !displayMenu;
                    currentSkyLocation++;
                    if(currentSkyLocation > skyLocations.Count - 1)
                    {
                        currentSkyLocation = 0;
                    }
                    xrOrigin.transform.position = skyLocations[currentSkyLocation];

                    Debug.Log("pressing primary button");
                    timestamp = Time.time;
                }




                rightController.TryGetFeatureValue(CommonUsages.secondaryButton, out bool secondaryButtonValue);
                if (secondaryButtonValue)
                {
                    //xrOrigin.transform.position = teleportLocations[currentTeleportLocation];
                    currentGroundLocation++;
                    if (currentGroundLocation > groundLocations.Count - 1)
                    {
                        currentGroundLocation = 0;
                    }
                    xrOrigin.transform.position = groundLocations[currentGroundLocation];
                    Debug.Log("pressing secondary button");
                    timestamp = Time.time;

                }

                rightController.TryGetFeatureValue(CommonUsages.triggerButton, out bool triggerButtonValue);
                if (triggerButtonValue)
                {
                    //xrOrigin.transform.position = teleportLocations[currentTeleportLocation];
                    panelActive = !panelActive;
                    HousePanel.SetActive(panelActive);
                    Debug.Log("pressing trigger button" + " panel Active is: " + panelActive);
                    timestamp = Time.time;

                }





                //rightController.TryGetFeatureValue(CommonUsages.primary2DAxis, out Vector2 primary2DAxisValue);
                //if (primary2DAxisValue != Vector2.zero && Mathf.Abs(primary2DAxisValue.x) > 0.5f)
                //{
                //    Debug.Log("primary touchpad: " + primary2DAxisValue);
                //    timestamp = Time.time;

                //}
                //rightController.TryGetFeatureValue(CommonUsages.primary2DAxisClick, out bool primary2DAxisClick);
                //if (primary2DAxisClick)
                //{
                //    currentTeleportLocation++;
                //    if (currentTeleportLocation > teleportLocations.Count -1)
                //    {
                //        currentTeleportLocation = 0;
                //    }
                //    Debug.Log("pressing primary axis");
                //    timestamp = Time.time;

                //}



            }
           
        }
    }
}
