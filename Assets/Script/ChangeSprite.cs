using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSprite : MonoBehaviour
{
    public Sprite[] sprites;
    SpriteRenderer sprite_R;
    void Awake()
    {
        sprite_R = GetComponent<SpriteRenderer>();
        Change();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //구름, 산 종류 랜덤 구현
    public void Change()
    {
        int ran = Random.Range(0, sprites.Length);
        sprite_R.sprite = sprites[ran];
    }
}
