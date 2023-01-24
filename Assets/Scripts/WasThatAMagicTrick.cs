using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WasThatAMagicTrick : MonoBehaviour
{
    private bool _isHidden;
    [SerializeField] private GameObject _cube;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("MagicTrick");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I)&&_isHidden==true)
        {
            _cube.SetActive(true);
        }
    }

    private IEnumerator MagicTrick()
    {
        yield return new WaitForSeconds(5);
        _isHidden = true;
    }
}
