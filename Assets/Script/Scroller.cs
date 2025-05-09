using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scroller : MonoBehaviour
{

    public int count;
    public float speedRate;

    void Start()
    {
        count = transform.childCount;
    }

    //¹«ÇÑ ¸Ê
    void Update()
    {
        if (!GameManager.isLive)
            return;

        float totalSpeed = GameManager.globalSpeed * speedRate * Time.deltaTime * -1.5f;
        transform.Translate(totalSpeed, 0, 0);
    }
}
