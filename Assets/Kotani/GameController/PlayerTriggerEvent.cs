using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTriggerEvent : MonoBehaviour
{
  [SerializeField]
  private PlayerControllerr PlayerControllerr;
  [SerializeField]
  private GameOverChanger GameOverChanger;
void OnCollisionEnter2D(Collision2D Collision)
  {
    switch(Collision.gameObject.tag)
    {
        case "Gool":
        Debug.Log("ゴールしました");
        GameOverChanger.GameClear();
        break;
        case "GameOver":
        GameOverChanger.GameOver();
        break;
        case "Filed":
        if(PlayerControllerr.jumpmax != 2)
        {
        PlayerControllerr.jumpmax=2;
        }
        break;
    }
  }
}
