using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TipCalculator : MonoBehaviour
{
    private int _bill = 40;
    [SerializeField] private float _tip;
    private float _tipAmount;
    private float _totalAmount;

    // Start is called before the first frame update
    void Start()
    {
        _tipAmount = (_tip / 100) * _bill;
        _totalAmount = _bill + _tipAmount;
        Debug.Log(_tipAmount);
        Debug.Log("Your bill is: " + _bill + "and your tip amount is: " + _tipAmount + "so you owe: " + _totalAmount);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
