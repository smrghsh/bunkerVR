using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ExampleListener : MonoBehaviour
{
    public ButtonHandler primaryAxisClickHandler = null;
    public void OnEnable()
    {
        primaryAxisClickHandler.OnButtonDown += PrintPrimaryButtonDown;

    }

    public void OnDisable()
    {
        primaryAxisClickHandler.OnButtonDown -= PrintPrimaryButtonDown;
    }

    private void PrintPrimaryButtonDown(XRController controller)
    {
        print("primary button down");
    }

    private void PrintPrimaryButtonUp(XRController controller)
    {

    }

    private void PrintPrimaryAxis(XRController controller, Vector2 value)
    {

    }

    private void PrintTrigger(XRController controller, float value)
    {

    }
}
