using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mech : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        MechWorkshopExample.colorChange += SwitchColor;
    }
    private void OnDisable()
    {
        MechWorkshopExample.colorChange -= SwitchColor;
    }

    private void SwitchColor( Color color,Vector3 pos)
    {
        transform.position = pos;
      var newColor =  GetComponent<MeshRenderer>().material.color = Random.ColorHSV();
        color = newColor;      
    }
}
