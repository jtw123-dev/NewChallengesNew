using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConvertForLoop : MonoBehaviour
{
    [SerializeField] private GameObject[] _cubes;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        for(int i=0;i<_cubes.Length;i++)
        {
            _cubes[i].GetComponent<MeshRenderer>().material.color = Color.green;
            //GetComponent<MeshRenderer>().material.color = Color.green;
        }
    }
}
