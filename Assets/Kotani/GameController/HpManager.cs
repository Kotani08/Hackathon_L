using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HpManager : MonoBehaviour
{
    [SerializeField]
    private Player playerStatus;
    [SerializeField]
    private List<GameObject> HpSprite = new List<GameObject>();
    void Update()
    {
        HpDisp();
    }
    /*public void PlayerHpDown(int value)
    {
        playerStatus.playerHP - value;
        HpDisp();
    }*/
    public void HpDisp()
    {
        int a = playerStatus.playerHP;
        for(;a >=1;a--)
        {
            #region 悪い書き方なので隠します
            //
            if(a>=5)
            {
                HpSprite[0].SetActive(true);
                HpSprite[1].SetActive(true);
                HpSprite[2].SetActive(true);
                HpSprite[3].SetActive(true);
                HpSprite[4].SetActive(true);
                break;
            }
            #endregion

            if(HpSprite[a].activeSelf == false)
            {
            HpSprite[a].SetActive(true);
            }
        }
    }
}
