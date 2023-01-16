using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfChallengeSpaceBarPress : MonoBehaviour
{
    [SerializeField] private int _score;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _score += 10;

            if (_score>=50)
            {
                Debug.Log("You are awesome");
            }
        }
    }
}
