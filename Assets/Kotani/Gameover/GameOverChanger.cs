using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;

public class GameOverChanger : MonoBehaviour
{
    [SerializeField]
    private Player playerStatus;
    [SerializeField]
    private GameObject player;
    private Vector3 ResetVec;
    [SerializeField]
    private PlayerControllerr playerController;
    [SerializeField]
    private GameObject gameOverPanel;
    // Update is called once per frame
    void Awake()
    {
        ResetVec = player.transform.localPosition;
    }
    void Update()
    {
        if(playerStatus.playerHP <= 0)
        {
            GameOver();
        }
        else
        {
            if(gameOverPanel.activeSelf == false)
            {
            playerController.Playerwalk();
            }
        }
        if(Input.GetKeyDown(KeyCode.R))
        {
            Retry();
        }
        if (Gamepad.current != null){if(Gamepad.current.rightShoulder.wasPressedThisFrame){Retry();}}
        if(Input.GetKeyDown(KeyCode.X))
        {
            playerStatus.playerHP-=10;
        }
    }
    #region ちっちゃいやつ
    public void GameOver()
    {
        //GameOver画面を表示
        //キャラクターの制御を止める
        if(gameOverPanel.activeSelf == false)
        {
        gameOverPanel.SetActive (true);
        gameOverPanel.transform.Find("Text").gameObject.GetComponent<Text>().text ="ゲームオーバー";
        }
    }
    public void GameClear()
    {
        //GameOver画面を表示
        //キャラクターの制御を止める
        if(gameOverPanel.activeSelf == false)
        {
        gameOverPanel.SetActive (true);
        gameOverPanel.transform.Find("Text").gameObject.GetComponent<Text>().text ="ゲームクリア";
        }
    }
    public void Retry()
    {
        player.transform.localPosition = player.transform.localPosition;
        gameOverPanel.SetActive (false);
        //キャラクターのHPなどのリセット
        player.transform.localPosition = ResetVec;
        playerStatus.playerHP = 3;
    }
    #endregion
    
}
