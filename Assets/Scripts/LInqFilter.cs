using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

[System.Serializable]
public class Item
{
    public string name;
    public int itemID;
    public int buff;
}


public class LInqFilter : MonoBehaviour
{
    public List<Item> items;
    // Start is called before the first frame update
    void Start()
    {
        var foundItem = items.Any(item => item.itemID == 3);
        var buffItems = items.Where(item => item.buff > 20);
        var buffAverage =   items.Sum(item => item.buff/items.Count);
        Debug.Log(buffAverage);

        foreach(var item in buffItems)
        {
            Debug.Log(item.name);
        }
        if (foundItem==true)
        {
            Debug.Log("Item exists");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
