using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnController : MonoBehaviour
{


    // Update is called once per frame
    void Update()
    {
      
        DetectTap();
    }
    public void DetectTap()
    {
        if (Input.GetMouseButtonDown(0)){

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, 100))
            {
               
            }
        }
    }
}

