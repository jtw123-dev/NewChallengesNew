using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class DelegatePractice : MonoBehaviour
{
    public Func<string> GetName;
    public delegate string ReturnGameObjectName();
    public ReturnGameObjectName returnName;
    // Start is called before the first frame update
    void Start()
    {
        GetName = () => this.gameObject.name;
        Debug.Log(GetName());
      //  GetName = ReturnName; These two lines get the name with a func 
      //  Debug.Log(GetName());
      // returnName = ReturnName; These two lines get the name with a delegate
     // Debug.Log(returnName());
    }

   // public string ReturnName()
   // {
   //     return  this.gameObject.name;
    //}

    
}
