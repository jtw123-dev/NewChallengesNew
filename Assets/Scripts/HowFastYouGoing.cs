using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HowFastYouGoing : MonoBehaviour
{
   [SerializeField] private int _maxSpeed;
   [SerializeField] private int _speed;
    // Start is called before the first frame update
    void Start()
    {
        _maxSpeed = Random.Range(60, 120);
        StartCoroutine("SpeedIncrease");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator SpeedIncrease()
    {
        while(_speed<_maxSpeed)
        {
            _speed += 5;
            yield return new WaitForSeconds(1);
        }


       
    }
}
