using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// SampleEnemyBase���p��
public class SampleEnemy : SampleEmemyBase
{
    // Ex--------------------------------------------------------
    // �V�������̃G�l�~�[��p�̕ϐ���֐���錾�ł���
    private int hoge = 0;

    public void Foo()
    {
        Debug.Log("�I���W�i���̊֐��ł�");
    }
    // ----------------------------------------------------------


    // �p������virtual�֐����I�[�o�[���C�h
    protected override void Move()
    {
        // Ex---------------------------------------------------------------
        // �p�����̏��������s���邱�Ƃ��ł���
        // ���ʂ��鏈��������ꍇ�ɕ֗�
        base.Move();

        // �I���W�i���̏������ǋL�ł���
        Debug.Log("SampleEnemy��Move�֐��ł�");

        // �p�����̌��J����Ă���ϐ��������̂��̂Ƃ��Ĉ�����
        Debug.Log(_attackPower);

        // �I�[�o�[���C�h���Ȃ���Β��ڌp�����̊֐��݂̂��������Ƃ��ł���
        // -----------------------------------------------------------------
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
