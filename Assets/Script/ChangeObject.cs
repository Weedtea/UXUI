using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeObject : MonoBehaviour
{
    public GameObject[] objs;
    
    //선인장 종류 랜덤
public void Change()
    {
        int ran = Random.Range(0, objs.Length);

        for(int index=0; index<objs.Length; index++) { 
            transform.GetChild(index).gameObject.SetActive(ran == index);
        }
    }
}
