using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MechWorkshopExample : MonoBehaviour
{
    public delegate void ChangeColors(Color color,Vector3 pos);
    public static event ChangeColors colorChange;
   
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag=="Enemy")
        {
            colorChange?.Invoke(Random.ColorHSV(),transform.position);           
        }
    }
}
