using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class MonoSingleton<T> : MonoBehaviour where T : MonoSingleton<T>
{
    private static T _instance;
    public static T Instance
    {
        get
        {
            if (_instance==null)
            {
                Debug.Log(typeof(T).ToString()+ "is Null");
            }
            return _instance;
        }
    }

    private void Awake()
    {
        _instance =  this as T; //also fine is casting (T) this
    }

    public virtual void Init()
    {
        //optional to override.
    }
}
