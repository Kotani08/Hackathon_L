using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int playerHP;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         //自身の座標をX方向に-1移動させる
        //Time.deltaTimeは前回のフレームから経過秒数
       //this.transform.Translate(new Vector3(-1f * Time.deltaTime,0f,0f));
       //Aキーが押された時
       if(Input.GetKey(KeyCode.A))
       {
            this.transform.Translate(new Vector3(-1f * Time.deltaTime,0f,0f));
       }
    //Dキーが押された時
       if(Input.GetKey(KeyCode.D))
       {
           this.transform.Translate(new Vector3(1f * Time.deltaTime,0f,0f));
       }
    }private string enemyTag = "Enemy";

#region//接触判定
private void OnCollisionEnter2D(Collision2D collision)
{
    if (collision.collider.tag == enemyTag)
    {
        this.gameObject.SetActive(false);
    }
}
private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            playerHP -= 1;
            
            Destroy(other.gameObject);

            if (playerHP == 0)
            {
                
                
                 
                 
                 Destroy(gameObject,3f);
             }
             else
             {
                 transform.Rotate(new Vector3(0,0,5));
             } 

                // プレーヤーを破壊するのではなく、非アクティブ状態にする（ポイント）
                this.gameObject.SetActive(false);
            }
        }
    }
#endregion

    
     
    

