using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SamplePlayer : MonoBehaviour
{
    [SerializeField, Header("ライフ")]
    private int _HP = 5;
    [SerializeField, Header("攻撃力")]
    private int _attackPower = 1;
    [SerializeField, Header("移動速度")]
    private float _moveSpeed = 10;
    [SerializeField, Header("被ダメージ後の無敵時間")]
    private float _invincibleTimeOfDamaged = 2;
    /// <summary>
    /// 被ダメージによって無敵状態か (true = 無敵状態, false = 通常状態)
    /// </summary>
    private bool _isInvincibleOfDamaged = false;
    /// <summary>
    /// 被ダメージによる無敵状態経過時間カウント
    /// </summary>
    private float _elapsedTimeInvOfDamaged = 0;


    /// <summary>
    /// 左右の移動
    /// </summary>
    /// <param name="move"></param>
    private void Move(float move)
    {
        // 移動距離の計算

        // ゲームオブジェクトにスピードを与える

        // 正しい向きにスプライトを反転
    }


    /// <summary>
    /// 攻撃アクションの開始
    /// </summary>
    private void Attack()
    {
        // 攻撃用の当たり判定を出す(アニメーションを使うと楽)
    }
    

    /// <summary>
    /// プレイヤーの攻撃判定に敵がヒットした時に呼ばれる、その敵のダメージ処理を呼ぶ
    /// </summary>
    public void OnHitAttack(SampleEmemyBase enemy)
    {
        // 引数の敵を参照し敵のダメージ処理関数を呼ぶ
    }

    
    /// <summary>
    /// 敵の攻撃がプレイヤーにヒットしたときに呼ばれる、プレイヤーはダメージを受ける
    /// </summary>
    public void AddDamage(int damage = 1)
    {
        // 無敵状態ならダメージを受けない

        // 引数のダメージをプレイヤーに与える

        // ライフが0以下になった場合、死亡時の処理を呼ぶ

        // そうでなければ無敵時間に入る
    }


    /// <summary>
    /// 毎フレーム呼ばれる、プレイヤーの無敵時間を管理
    /// </summary>
    private void Invincible()
    {
        // 無敵状態でなければ処理しない

        // 前フレームからの経過時間をカウント

        // トータルの経過時間が無敵時間を超えたら無敵状態を解除
    }


    /// <summary>
    /// プレイヤーが死亡したときに呼ばれる、死亡時処理を呼ぶ
    /// </summary>
    private void Die()
    {
        // ゲームオーバー処理などを呼ぶ
    }
}
