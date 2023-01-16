using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCubeColorSwitch : MonoBehaviour
{
    [SerializeField] private GameObject _object;
    private int _input;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            _input = 0;
        }

        else if (Input.GetKeyDown(KeyCode.W))
        {
            _input = 1;
        }

        else if (Input.GetKeyDown(KeyCode.S))
        {
            _input = 2;
        }

        else if (Input.GetKeyDown(KeyCode.D))
        {
            _input = 3;
        }

        switch (_input)
        {
            case 0:
                _object.GetComponent<MeshRenderer>().material.color = Color.blue;
                break;

            case 1:
                _object.GetComponent<MeshRenderer>().material.color = Color.red;
                break;

            case 2:
                _object.GetComponent<MeshRenderer>().material.color = Color.green;
                break;
            case 3:
                _object.GetComponent<MeshRenderer>().material.color = Color.black;
                break;

        }

    }
}
