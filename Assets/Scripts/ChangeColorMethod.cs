using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColorMethod : MonoBehaviour
{
    [SerializeField] GameObject _player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ChangeColor(_player, Color.green);
        }
    }

    private void ChangeColor(GameObject player,Color  color )
    {
        player.GetComponent<MeshRenderer>().material.color = color;
    }
}
