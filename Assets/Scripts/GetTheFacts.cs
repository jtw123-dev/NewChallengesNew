using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;

[System.Serializable]
public class CatFact
{
    public string fact; 
}


public class GetTheFacts : MonoBehaviour
{
    [SerializeField] private Text _catFactText;
    private string _url;// uses this to grab url //he got the error
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            StartCoroutine(GetTheFactsRoutine("https://catfact.ninja/fact"));
            //StartCoroutine(GetTheFactsRoutine("https://error.html"));
           

        }
    }

    private IEnumerator GetTheFactsRoutine(string uri)
    {
        using (UnityWebRequest webRequest = UnityWebRequest.Get(uri))//using allows us to not keep the info for the life of the program but deletes it
        {
            yield return webRequest.SendWebRequest();
            //check if request.is network error|| request isHttpError always check if your request was successful and than print out text
            string[] pages = uri.Split('/');
            int page = pages.Length - 1;

            switch (webRequest.result)
            {
                case UnityWebRequest.Result.ConnectionError:
                case UnityWebRequest.Result.DataProcessingError:
                    Debug.LogError(pages[page] + ": Error: " + webRequest.error);
                    break;
                case UnityWebRequest.Result.ProtocolError:
                    Debug.LogError(pages[page] + ": HTTP Error: " + webRequest.error);
                    break;
                case UnityWebRequest.Result.Success:
                    Debug.Log(pages[page] + ":\nReceived: " + webRequest.downloadHandler.text);
                    var json = webRequest.downloadHandler.text;
                    var catFact = JsonUtility.FromJson<CatFact>(json);
                    _catFactText.text = catFact.fact;
                    //_catFactText.text = webRequest.downloadHandler.text; //gets text but is in json
                    break;
                    //how to convert cat fact json to c# data model json2Csharp can convert the text. turn into class
            }

        }


            
    }
}
