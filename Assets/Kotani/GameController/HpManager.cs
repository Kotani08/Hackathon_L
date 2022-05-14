using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HpManager : MonoBehaviour
{
    [SerializeField]
    private PlayerStatus playerStatus;
    [SerializeField]
    private Text Hptext;
    void Update()
    {
        if(playerStatus.GetHp()<=0)
        {
            playerStatus.SetHp(0);
        }
        Hptext.text = "HP:" + playerStatus.GetHp().ToString()+"/100";
    }
    public void PlayerHpDown(int value)
    {
        playerStatus.SetHp(playerStatus.GetHp() - value);
    }
}
