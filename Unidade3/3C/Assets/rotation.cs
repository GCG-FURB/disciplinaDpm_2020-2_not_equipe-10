using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotation : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Aviao; 
    public int speed;
    int value = 10;

    // Update is called once per frame
    void Update()
    {
        Aviao.transform.rotation =  Quaternion.Euler(0, 0, value);
        value += speed;
    }
}
