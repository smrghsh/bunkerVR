using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class InputManager : MonoBehaviour
{
    public List<ButtonHandler> allButtonHandlers = new List<ButtonHandler>();

    public XRController controller;

    private void Awake()
    {
        print("trying to get controller");
        controller = GetComponent<XRController>();
        
    }

    private void Update()
    {
        HandleButtonEvents();
    }

    private void HandleButtonEvents()
    {
        foreach (ButtonHandler handler in allButtonHandlers)
            handler.HandleState(controller);
    }

    private void HandleAxis2DEvents()
    {

    }

    public void HandleAxisEvents()
    {

    }
}

