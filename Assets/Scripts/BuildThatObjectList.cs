using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildThatObjectList : MonoBehaviour
{
    [SerializeField] private List<GameObject> _objects;//since it is a fixed amount array might be better attach script to gameManager instead of main camera
    [SerializeField] private List<GameObject> _objectsCreated;
    [SerializeField] private int _index;
    private bool _canSpawn =true;
   

    // Update is called once per frame
    void Update()
    {
       

        if (Input.GetKeyDown(KeyCode.Space) &&_canSpawn==true)
        {
          var randomObjSelected=  Instantiate(_objects[Random.Range(0, _objects.Count)],new Vector2(Random.Range(-10,10),Random.Range(-10,10)),Quaternion.identity);
            _objectsCreated.Add(randomObjSelected);
            _index++;

            if(_index==10)
            {
                _canSpawn = false; //use a bool so you are not calling this foreach loop 60 or more times per second.
                foreach (var obj in _objectsCreated)
                {
                    obj.GetComponent<MeshRenderer>().material.color = Color.green;
                }
                _objectsCreated.Clear();
            }
        }
    }
}
