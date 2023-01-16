using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopForNumbers : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        for (int i =0; i<31;i++)
        {
            if (i<=10)
            {
                Debug.Log(i);
            }
           
            else if (i>10&& i<21 && i%2==0)
            {
                Debug.Log(i);
            }

            else if (i>20 && i<31 && i%2!=0)
            {
                Debug.Log(i);
            }
        }
    }
}
