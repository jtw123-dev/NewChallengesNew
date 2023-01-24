using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private GameObject _obj;
    private float _time;
    // Start is called before the first frame update
    void Start()
    {
        _time = 5 * Time.deltaTime;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            RandomColorHelper.ColorChanger(_obj);
        }
    }
}
