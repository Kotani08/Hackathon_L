using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// SampleEnemyBaseを継承
public class SampleEnemy : SampleEmemyBase
{
    // Ex--------------------------------------------------------
    // 新しくこのエネミー専用の変数や関数を宣言できる
    private int hoge = 0;

    public void Foo()
    {
        Debug.Log("オリジナルの関数です");
    }
    // ----------------------------------------------------------


    // 継承元のvirtual関数をオーバーライド
    protected override void Move()
    {
        // Ex---------------------------------------------------------------
        // 継承元の処理を実行することもできる
        // 共通する処理がある場合に便利
        base.Move();

        // オリジナルの処理も追記できる
        Debug.Log("SampleEnemyのMove関数です");

        // 継承元の公開されている変数を自分のものとして扱える
        Debug.Log(_attackPower);

        // オーバーライドしなければ直接継承元の関数のみを扱うことができる
        // -----------------------------------------------------------------
    }


    protected override void Attack()
    {
        // 攻撃モーションの再生など
    }


    public override void OnHitAttack()
    {
        // プレイヤーの被ダメージ関数を呼ぶ
    }


    public override void AddDamage(int damage = 1)
    {
        // 引数のダメージを受ける

        // ライフが0以下になったら死亡処理を行う
    }


    protected override void Die()
    {
        // ※オーバーライドする必要はないかも
    }


    /// <summary>
    /// このエネミーにコライダーが侵入したときに呼ばれる、それがプレイヤーならプレイヤーのダメージ処理を呼ぶ
    /// </summary>
    /// <param name="collision"></param>
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // ヒットしたコライダーがプレイヤーでなければ処理しない

        // プレイヤーのダメージ処理を呼ぶ
    }
}
