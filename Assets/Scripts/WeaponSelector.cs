using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSelector : MonoBehaviour
{
    [SerializeField]private int _weaponID;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        switch (_weaponID)
        {
            case 0:
                Debug.Log("You selected gun");
                break;

            case 1:
                Debug.Log("You selected knife");
                break;

            case 2:
                Debug.Log("You selected machine gun");
                break;
        }

    }
}
