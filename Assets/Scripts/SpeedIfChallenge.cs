using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedIfChallenge : MonoBehaviour
{
    private float _speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.S))
        {
            _speed += 5;

            if(_speed==20)
            {
                Debug.Log("Slow down");
            }
        }

        else if (Input.GetKeyDown(KeyCode.A))
        {
            _speed -= 5;
            if (_speed<=0)
            {
                _speed = 0;
                Debug.Log("You need to speed up");
            }

           
        }
    }
}
