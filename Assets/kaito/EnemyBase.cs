using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBase : MonoBehaviour
{
    [SerializeField, Header("ライフ")]
    protected int _HP = 5;
    [SerializeField, Header("攻撃力")]
    protected int _attackPower = 1;




    /// <summary>
    /// エネミーの移動
    /// </summary>
    protected virtual void Move()
    {

    }


    /// <summary>
    /// 攻撃アクションの開始
    /// </summary>
    protected virtual void Attack()
    {

    }


    /// <summary>
    /// このエネミーの攻撃判定にプレイヤーがヒットした時に呼ばれる、プレイヤーのダメージ処理を呼ぶ
    /// </summary>
    public virtual void OnHitAttack()
    {

    }


    /// <summary>
    /// プレイヤーの攻撃がこのエネミーにヒットしたときに呼ばれる、このエネミーはダメージを受ける
    /// </summary>
    public virtual void AddDamage(int damage = 1)
    {

    }


    /// <summary>
    /// エネミーの死亡時処理
    /// </summary>
    protected virtual void Die()
    {

    }
}
