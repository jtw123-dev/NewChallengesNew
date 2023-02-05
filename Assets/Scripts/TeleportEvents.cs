using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportEvents : MonoBehaviour
{
    public delegate void Teleport(Vector3 pos);
    public static  event Teleport onTeleport;
    public delegate void MoveCube();
    public static event MoveCube onSpace;

    public void OnSpace()
    {
     //   onSpace?.Invoke();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
          
            onTeleport?.Invoke(new Vector3(5,2,0));
          //  onTeleport(new Vector3(5, 2, 0));
            
           // OnSpace();
        }
       
    }
}
