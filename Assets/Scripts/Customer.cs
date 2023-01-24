using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Customer 
{
    public string firstName, secondName, gender, occupation;
    public int age;

    public Customer(string firstName, string secondName, string gender, string occupation, int age)
    {
        this.firstName = firstName;
        this.secondName = secondName;
        this.gender = gender;
        this.occupation = occupation;
        this.age = age;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
