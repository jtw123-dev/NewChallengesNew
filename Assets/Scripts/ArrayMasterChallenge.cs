using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayMasterChallenge : MonoBehaviour
{
    [SerializeField] private string[] _name;
    [SerializeField] private int[] _age;
    [SerializeField] private string[] _cars;
    [SerializeField] private int _index;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _index = Random.Range(0, _name.Length);
            Debug.Log( "The name is " + _name [_index]  + " and the age is "  + _age [_index] + " and their favorite car is "  +  _cars [_index]);
           // Debug.Log(_name[4]);
           // Debug.Log(_age[4].ToString());
           // Debug.Log(_cars[4]);

        
        }
    }
}
