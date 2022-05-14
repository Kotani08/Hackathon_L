using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStatus : MonoBehaviour
{
    [SerializeField]
    private int hp=0;
    public int GetHp()//外部から値を取得したい時用
   {
       return hp;
   }
   public void SetHp(int value)//外部から値を設定したい時用
   {
       hp = value;
   }
}
