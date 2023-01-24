using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Properties : MonoBehaviour
{
    public float speed { get; private set; }
    public string names { get; set; }
    private string _name;
    public string Name
    {
        get
        {
            return _name;
        }
        set
        {
            _name = value;
        }
    }

    private float _speed;
    public float Speed
    {
        get
        {
            return _speed;
        }
        private set
        {
            _speed = value;
        }
      
    }

    // Start is called before the first frame update
    void Start()
    {
        Speed = 5f;
        _name = "Josh";
        Debug.Log("Speed is " + Speed);
        Debug.Log("Name is " + _name);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
