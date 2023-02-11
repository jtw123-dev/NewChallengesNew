using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class MoreDelegatePractice : MonoBehaviour
{
    public Func<string, int> howLong;
    public delegate int NameLength(string name);
    public NameLength nameLength;
    // Start is called before the first frame update
    void Start()
    {
       // howLong = LengthOfName; with simple delegate 
       // howLong(gameObject.name);

      //  nameLength = LengthOfName; with func
      //  nameLength(gameObject.name);
       // Debug.Log(nameLength(gameObject.name));

        howLong =(string name)=>name.Length;//Lambda
        
        Debug.Log(howLong(gameObject.name));
    }

    public int LengthOfName(string name)
    {
        name = gameObject.name;
        return name.Length;    
    }
}
