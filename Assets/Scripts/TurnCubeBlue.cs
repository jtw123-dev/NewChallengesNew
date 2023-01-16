using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnCubeBlue : MonoBehaviour
{
    [SerializeField] private GameObject _cube;
    private int _score;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            _score += 10;
            if (_score>50)
            {
                _cube.GetComponent<Renderer>().material.color = Color.green;
            }
        }
    }
}
