using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1 : EnemyBase
{
    [SerializeField]
   private float speed = 1f;
    int counter = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        counter++;
        if (counter == 1000)
        {
            counter = 0;
            speed *= -1;
        }

    }
    
   

    // 継承元のvirtual関数をオーバーライド
    protected override void Move()
    {
        transform.Translate(new Vector3(speed, 0, 0));
       
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


