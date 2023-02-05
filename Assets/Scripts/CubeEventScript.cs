using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeEventScript : MonoBehaviour
{
    
    private void Start()
    {
        TeleportEvents.onTeleport += Spawn;
    }


    // Update is called once per frame
    void Update()
    {
       // if (Input.GetKeyDown(KeyCode.Space))
    //    {
      //      TeleportEvents.onSpace += MovingCube;
     //   }
    }
    public void MovingCube()
    {
       //transform.position = new Vector3(5, 2, 0);
    }

    public void Spawn(Vector3 pos)
    {
        transform.position = pos;
    }
}
