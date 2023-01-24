using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AreYouAlive : MonoBehaviour
{

    private bool _isDead;
    [SerializeField]private int _health;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (_health<1)
        {
            Debug.Log("Player is dead");
            _isDead = true;
            _health = 0;
        }
        if (Input.GetKeyDown(KeyCode.Space) &&_isDead==false)
        {
            _health -= Random.Range(1, 10);
        }
    }
}
 