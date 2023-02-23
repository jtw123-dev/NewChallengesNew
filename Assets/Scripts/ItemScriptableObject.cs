using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="ObjectToSpawn",menuName ="ObjectExample", order =1)]
public class ItemScriptableObject:ScriptableObject
{
    public GameObject _spawnObject; //make this a list instead
    //by making this a list you can just make a wave 1 than wave 2 
    //could also create a name variable

    
}
