using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchChallenge : MonoBehaviour
{
    private int _points;
    private int _index;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            _points = 50;
            _index = 0;
        }

        else if (Input.GetKeyDown(KeyCode.S))
        {
            _index = 1;
            _points = 100;
        }

        else if (Input.GetKeyDown(KeyCode.E))
        {
            _index = 2;
            _points = 0;
        }
        switch (_index)
        {
            case 0:
                Debug.Log("Points are 50");
                break;
            case 1:
                Debug.Log("Points are 100");
                break;
            case 2:
                Debug.Log("Points are 0");
                break;
        }

            

    }
}
