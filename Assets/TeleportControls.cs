using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;


public class TeleportControls : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        List<InputDevice> devices = new List<InputDevice>();
        InputDevices.GetDevices(devices);
        print(devices.Count);
        foreach (var item in devices)
        {
            Debug.Log(item.name + item.characteristics);
        }

    }
}
