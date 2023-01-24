using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YouHaveBeenNamed : MonoBehaviour
{
    [SerializeField] private List<string> _names;// = new List<string>();
    private int _index;

    // Start is called before the first frame update
    void Start()
    {
        
        foreach(var name in _names)
        {
            Debug.Log(name);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //_index = Random.Range(0, _names.Count);
            _names.Remove(_names[Random.Range(0,_names.Count)]);

            foreach(var name in _names)
            {
                Debug.Log(name);
            }
        }
    }
}
