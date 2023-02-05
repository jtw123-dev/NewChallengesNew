using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PartTimeEmployee :EmployeeExperience
{
    [SerializeField] private float _hoursWorked,_hourlyRate;
    // Start is called before the first frame update
    void Start()
    {
        CalculateMonthlySalary();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void CalculateMonthlySalary()
    {
        
        Debug.Log(_hoursWorked * _hourlyRate);
    }
}
