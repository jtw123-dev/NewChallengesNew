using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerSingleton : MonoSingleton<SpawnManagerSingleton> //this will turn it into a singleton without having to do anything else
{
    public override void Init()
    {
        base.Init();
    }

    public void Testing()
    {
        Debug.Log("Testing");
    }
}
