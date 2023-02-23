using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerForScriptableObjects : MonoBehaviour
{
    [SerializeField] private List<ItemScriptableObject> _scriptableList = new List<ItemScriptableObject>();
    [SerializeField] private List<ItemScriptableObject> _objToSpawn = new List<ItemScriptableObject>();
    private GameObject _clone;
    private int _waveIndex;
    private int _waveObj;
    private bool _allWavesComplete = true;
    // Update is called once per frame

    private void Start()
    {
        StartCoroutine(StartWaveRoutine());
    }
    IEnumerator StartWaveRoutine()
    {

        while (_allWavesComplete ==true)
        {
            //var currentwave  = _waves[currentWave].sequence the name in the itemScriptableobject class
            //var previousWave = new GameObject ("PreviousWave") this will store a clone that we can delete than we can parent this and delete it much like 
            //how we make our bullets a parent of an empty gameobject

            //foreach (var obj in currentWave)

            //{
                // Instantiate (obj,previousWave.transform);
            //}

            //Delete(previousWave);
            switch (_waveIndex)
            {
                case 0:
                    foreach(var obj in _scriptableList)
                    {
                        _clone = Instantiate(obj._spawnObject, new Vector3(0, 0, 0), Quaternion.identity);
                        _objToSpawn.Add(obj);
                        Destroy(_clone, 5);          
                    }
                    break;
                case 1:

                    foreach(var obj in _objToSpawn)
                    {
                        _clone = Instantiate(obj._spawnObject, new Vector3(0, 0, 0), Quaternion.identity);
                        _scriptableList.Add(obj);
                        Destroy(_clone,5);
                       
                    }
                   
                    break;
                case 2:

                    foreach(var obj in _scriptableList)
                    {
                        _clone = Instantiate(obj._spawnObject, new Vector3(0, 0, 0), Quaternion.identity);
                        _objToSpawn.Add(obj);
                        Destroy(_clone, 5);
                    }         
                    break;
            }
            yield return new WaitForSeconds(5);
            if (_waveIndex==3)
            {
                yield break;
            }
            _waveIndex++;
        }
    }
}
