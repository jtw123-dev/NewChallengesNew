using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserClick : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray rayOrigin = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitInfo;

            if (Physics.Raycast(rayOrigin,out hitInfo))
            {
                if (hitInfo.collider.tag == "Cube")
                {
                    ICommand click = new ClickCommand(hitInfo.collider.gameObject,Random.ColorHSV());
                    click.Execute();
                    CommandManager.Instance.AddCommands(click);

                   
                }
            }
        }
    }
}
