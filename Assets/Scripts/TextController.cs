using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class TextController : MonoBehaviour
{
    public TextMeshProUGUI _text;
    private string loading = "Loading.";

    void Start()
    {
        _text.text = loading;
        StartCoroutine(time());
    }

    IEnumerator time(){
        int count =0;
        while (true)
        {
            count++;
              _text.text += "." ;
              if(count == 5)
              {
                  _text.text = "_";
              }else if(count ==6)
              {
                  _text.text = "Hello World!";
                  break;
              }
            yield return new WaitForSeconds(1);
        }
    }
}