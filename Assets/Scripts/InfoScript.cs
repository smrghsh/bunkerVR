using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfoScript : MonoBehaviour
{
    private string bldgName;
    public GameObject infoCard;
    int counter = 0;
    bool counterActive = false;
    // Start is called before the first frame update
    void Start()
    {
        infoCard.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        /*
        if (Input.GetMouseButtonDown(0)) //If raycast triggered
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit Hit;
            if (Physics.Raycast(ray, out Hit))
            {
                bldgName = Hit.transform.name;
                if (bldgName == "Mesh2119")
                {
                    infoCard.SetActive(true);
                    counterActive = true;
                }
                
            }
        }
        if (counterActive)
        {
            counter = counter + 1;
            if(counter == 10000)
            {
                counter = 0;
                counterActive = false;
                infoCard.SetActive(false);
            }
        }
     */   
    }
}
