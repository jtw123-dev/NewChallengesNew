using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class EvenMoreDelegatePractice : MonoBehaviour
{
    public Func<int, int, int> sum;
    public delegate int AddTwoNumbers(int a, int b);
    public AddTwoNumbers answer;


    // Start is called before the first frame update
    void Start()
    {
       // answer = AddingNumbers;
      //  Debug.Log(answer(46, 49));
        answer = (a, b) => a + b;
        Debug.Log(answer(4, 5));

       // sum = (a, b) => a + b;
      //  Debug.Log(sum(450,700));
      ///  sum = AddingNumbers;
     //  Debug.Log( sum(5,6));
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public int AddingNumbers(int a, int b)
    {
        var total = a + b;
        return total;
    }
}
