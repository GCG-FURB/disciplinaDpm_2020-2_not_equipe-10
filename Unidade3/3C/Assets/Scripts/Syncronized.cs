using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Networking;
using System.IO;
using System.Text;

public class Syncronized : MonoBehaviour
{
    private Pessoa pessoa; 
    public TMP_InputField inputField;
    public TMP_InputField inputField2;

    public void SaveAndSynchronized()
    {
        pessoa =  new Pessoa(); 
        pessoa.Nome = inputField.text;
        pessoa.Idade = int.Parse(inputField2.text);
        Debug.Log(pessoa.Nome);

        SaveLocaly(pessoa);
        //StartCoroutine(Upload(pessoa.Nome));
    }

    IEnumerator Upload(Pessoa p) {
        WWWForm form = new WWWForm();
        form.AddField("Nome", p.Nome);
        form.AddField("Idade", p.Idade);
 
        UnityWebRequest www = UnityWebRequest.Post("https://jsonplaceholder.typicode.com/posts", form);
        yield return www.SendWebRequest();
 
        if(www.isNetworkError || www.isHttpError) {
            Debug.Log(www.error);
        }
        else {
            Debug.Log("Form upload complete!");
        }
    }

    public void SaveLocaly(Pessoa p){
         var path = @"C:\\Users\\Public\\UnityTeste.txt";

            string text = p.Nome + ";" + p.Idade;
            byte[] data = Encoding.ASCII.GetBytes(text);

            File.WriteAllBytes(path, data);
    }

}