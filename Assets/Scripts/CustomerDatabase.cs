using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomerDatabase : MonoBehaviour
{
   [SerializeField]private Customer _bob;
   [SerializeField]private Customer _tom;
   [SerializeField]private Customer _ida;
   [SerializeField]private Customer[] _customers;
    // Start is called before the first frame update
    void Start()
    {
        _bob = new Customer("Bob", "Wane", "M", "Cleaner", 44);
        _tom = new Customer("Tom", "Trellis", "M", "Programmer", 29);
        _ida = new Customer("Ida", "Ellis", "F", "Stay at home  mom", 25);


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
