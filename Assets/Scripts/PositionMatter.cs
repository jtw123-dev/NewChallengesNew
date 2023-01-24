using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionMatter : MonoBehaviour
{
    [SerializeField] private Vector3[] _positions;
   [SerializeField] private int _index;
    // Start is called before the first frame update
    void Start()
    {
        //_index = RandomIndex();
        RandomIndex();
        SetPositionToIndex(_positions[_index]);
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private int RandomIndex()
    {
         //could also say return Random.Range(0,_positions.Length);
        _index = Random.Range(0, _positions.Length);
        return _index;
    }

    private void SetPositionToIndex(Vector3 position)
    {
        transform.position = position;
    }
}
