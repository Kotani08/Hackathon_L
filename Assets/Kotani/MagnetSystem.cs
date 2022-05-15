using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagnetSystem : MonoBehaviour
{
    //tagを見て
    //同じ極なら周囲いくつ以内なら近づく
    //違う極なら反発する
    [SerializeField]
    private GameObject magobj;
    [SerializeField]
    private bool magType;//trueでN極 falseでS極
    public bool GetMagType()
    {
        return magType;//範囲に入った相手がどっちの極かを判断する
    }
    void OnCollisionEnter2D(Collision2D Collision)
    {
        //MagnetSystemを持っているオブジェクトが範囲に入ったらそのMagTypeによって分岐
        switch(Collision.gameObject.GetComponent<MagnetSystem>().GetMagType())
        {
            //ここによびだす
        }
    }
    public void Magnet(bool Type)
    {

    }
}
