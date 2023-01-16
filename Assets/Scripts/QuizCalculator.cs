using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class QuizCalculator : MonoBehaviour
{
   [SerializeField] private int[] _quizGrades ;
    private int _index;
    private int _gradeTotal;
    private float _averageGrade;
    // Start is called before the first frame update
    void Start()
    {
       
        foreach( var grade in _quizGrades)
        {      
            _quizGrades[_index] = Random.Range(0, 100);
            _index++;
            _gradeTotal = _quizGrades.Sum(itm => itm);
        }
        _averageGrade = _gradeTotal / 5;
        Debug.Log("Average grade is: " + _averageGrade);

        var passingGrade = _quizGrades.Where(g => g > 69);
        
        foreach(var grade in _quizGrades)
        {
            if (grade >90)
            {
                Debug.Log("You got an A");
            }

            else if (grade>80 && grade<90)
            {
                Debug.Log("You got a B");
            }

            else if (grade>70 && grade<80)
            {
                Debug.Log("You got a C");
            }
           else

            {
                Debug.Log("You got a F");
            }//Did not even need linq and be careful of the specifics of the challenge only needed to worry about average grade total not each individual one
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
