using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MagnetSystem : MonoBehaviour
{
    #region 宣言
    [SerializeField]
    private GameObject magobj;//自分のオブジェクトを入れる
    [SerializeField]
    private bool magType;//trueでN極 falseでS極と想定（ここの値を変えると極が変化する）
    [SerializeField]
    private float magpaw;//反発するちからor引かれる力が変化する(基本は100です)
    [SerializeField]
    private bool staicFlag;//磁力判定を持たせたいが動かしたくないオブジェクトはこれをtrueにする

    ///以下は可視化する必要のない変数
    private GameObject Target;//相手の位置
    private Vector2 Mypoj;//自分の位置
    private float distance;//お互いの距離を把握する
    public bool GetMagType()
    {
        return magType;//相手の極を判断する時に使うゲッター
    }
    public void SetMagType(bool i)
    {
        magType=i;
    }
    
    #endregion

    #region 磁力の範囲に入っている間にする処理
    void OnTriggerStay2D(Collider2D collider)
    {
        //staicFlagが負である かつ magobjがnull（未設定で）ない場合通過
        if(staicFlag!=true && magobj!=null)
        {
            //当たった相手がMagnetSystemを所持していた場合通過
            if(collider.gameObject.GetComponent<MagnetSystem>())
            {
                //相手のgameObjectを変数として所持
                Target = collider.gameObject;

                //必要な情報を関数MagneticForceにいれてそれっぽい動きをする
                MagneticForce(magobj.transform.position,
                              Target.gameObject.transform.position,
                              collider.gameObject.GetComponent<MagnetSystem>().GetMagType()
                             );
            }
        }
    }
    #endregion

    #region ダメな数学＆書き方なのでマネしないように解説無し
    private void MagneticForce(Vector2 MyObj,Vector2 Target,bool ContactObjType)
	{
        Vector2 set;
        distance = (MyObj - Target).magnitude;
        //自分の位置をVec2として所持
        Mypoj = magobj.transform.position;
        if(magType != ContactObjType)
        {
            magpaw=magpaw*-1;
        }
		if(MyObj.x <= Target.x)
        {
            //地面にめり込まないように要改善
            //自分の方が左にいる
            Mypoj.x = Mypoj.x -magpaw*Time.deltaTime*(0.01f*(1000f-distance));
        }
        else
        {
            //自分の方が右にいる
            Mypoj.x = Mypoj.x +magpaw*Time.deltaTime*(0.01f*(1000f-distance));
        }
        if(MyObj.y <= Target.y)
        {
            //自分の方が下にいる
            Mypoj.y = Mypoj.y -magpaw*Time.deltaTime*(0.01f*(1000f-distance));
        }
        else
        {
            //自分の方が上にいる
            Mypoj.y = Mypoj.y +magpaw*Time.deltaTime*(0.01f*(1000f-distance));
        }
        set.x=Mypoj.x;
        set.y=Mypoj.y;
        magobj.transform.position =set;
        magpaw=Mathf.Abs(magpaw);//絶対値に戻しておく
	}
    #endregion
}
