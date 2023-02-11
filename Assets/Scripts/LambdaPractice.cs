using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class LambdaPractice : MonoBehaviour
{
    public Action<int,int> AddingNumbers;
    public delegate void AddTwoNumbers(int a, int b);
    public  AddTwoNumbers sum;
    private int _total;
  
    // Start is called before the first frame update
    void Start()
    {
        AddingNumbers = (a, b) => _total = a + b;//Lambda
       // AddingNumbers = AddedTwoNumbersTogether;
        if (AddingNumbers!=null)
        {
            AddingNumbers(45,7);
            Debug.Log(_total);
        }
        AddingNumbers(5, 7);
        Debug.Log(_total);
        //sum=()=>
       
      //  sum = AddNumbers;
    //    sum(8,5);

       
      //  Debug.Log(_total);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            sum(5,5);
           // Debug.Log(_total);
        }
    }

    public void AddNumbers(int a , int b)
    {
        _total = a + b;       
    }

   // public void AddedTwoNumbersTogether(int a , int b)
   // {
   //     _total = a + b; can also use var to create a temporary variable to store the total
   // }
}
