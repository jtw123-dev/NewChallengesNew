using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class RandomColorHelper 
{
   public static void ColorChanger(GameObject  obj)
    {
        obj.GetComponent<MeshRenderer>().material.color = Random.ColorHSV();
    }
}
