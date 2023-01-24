using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoroutineColorChange : MonoBehaviour
{
    [SerializeField] private GameObject _object;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("ChangeColor");
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    private IEnumerator ChangeColor()
    {
        while (true)
        {
            yield return new WaitForSeconds(3);
            _object.GetComponent<MeshRenderer>().material.color = Random.ColorHSV();
        }
      
    }
}
