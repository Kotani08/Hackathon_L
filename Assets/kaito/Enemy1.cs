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
    
   

    // �p������virtual�֐����I�[�o�[���C�h
    protected override void Move()
    {
        transform.Translate(new Vector3(speed, 0, 0));
       
    }


    protected override void Attack()
    {
        // �U�����[�V�����̍Đ��Ȃ�
    }


    public override void OnHitAttack()
    {
        // �v���C���[�̔�_���[�W�֐����Ă�
    }


    public override void AddDamage(int damage = 1)
    {
        // �����̃_���[�W���󂯂�

        // ���C�t��0�ȉ��ɂȂ����玀�S�������s��
    }


    protected override void Die()
    {
        // ���I�[�o�[���C�h����K�v�͂Ȃ�����
    }


    /// <summary>
    /// ���̃G�l�~�[�ɃR���C�_�[���N�������Ƃ��ɌĂ΂��A���ꂪ�v���C���[�Ȃ�v���C���[�̃_���[�W�������Ă�
    /// </summary>
    /// <param name="collision"></param>
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // �q�b�g�����R���C�_�[���v���C���[�łȂ���Ώ������Ȃ�

        // �v���C���[�̃_���[�W�������Ă�
    }
}


