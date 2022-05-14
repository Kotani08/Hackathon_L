using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBase : MonoBehaviour
{
    [SerializeField, Header("���C�t")]
    protected int _HP = 5;
    [SerializeField, Header("�U����")]
    protected int _attackPower = 1;




    /// <summary>
    /// �G�l�~�[�̈ړ�
    /// </summary>
    protected virtual void Move()
    {

    }


    /// <summary>
    /// �U���A�N�V�����̊J�n
    /// </summary>
    protected virtual void Attack()
    {

    }


    /// <summary>
    /// ���̃G�l�~�[�̍U������Ƀv���C���[���q�b�g�������ɌĂ΂��A�v���C���[�̃_���[�W�������Ă�
    /// </summary>
    public virtual void OnHitAttack()
    {

    }


    /// <summary>
    /// �v���C���[�̍U�������̃G�l�~�[�Ƀq�b�g�����Ƃ��ɌĂ΂��A���̃G�l�~�[�̓_���[�W���󂯂�
    /// </summary>
    public virtual void AddDamage(int damage = 1)
    {

    }


    /// <summary>
    /// �G�l�~�[�̎��S������
    /// </summary>
    protected virtual void Die()
    {

    }
}
