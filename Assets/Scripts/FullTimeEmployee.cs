using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FullTimeEmployee : EmployeeExperience
{
    [SerializeField] private float _salary;
    // Start is called before the first frame update
    void Start()
    {
        CalculateMonthlySalary();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void  CalculateMonthlySalary()
    {
        Debug.Log(_salary);
    }
}
