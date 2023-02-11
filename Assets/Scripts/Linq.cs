using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class Linq : MonoBehaviour
{
    [SerializeField] private GameObject[] _cubes;
    [SerializeField] private int[] _quizGrades = { 44,55,32,77,95,99,88};
    // Start is called before the first frame update
    void Start()
    {

         var passingGrades = _quizGrades.Where(quiz => quiz > 69).OrderByDescending(g=>g).Reverse();
         
        foreach(var grade in passingGrades)
        {
            Debug.Log(grade);
        }
        
        var cubeFound = _cubes.Any(cube => cube.transform.position == new Vector3(0,0,0));

        if (cubeFound==true)
        {
            Debug.Log("True");
        }
       
        foreach (var cube in _cubes)
        {
            if (cube.transform.position == new Vector3(0, 0, 0))
           {
            //    Debug.Log("True");
           }
       }
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
