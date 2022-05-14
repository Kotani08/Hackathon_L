using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SamplePlayer : MonoBehaviour
{
    [SerializeField, Header("���C�t")]
    private int _HP = 5;
    [SerializeField, Header("�U����")]
    private int _attackPower = 1;
    [SerializeField, Header("�ړ����x")]
    private float _moveSpeed = 10;
    [SerializeField, Header("��_���[�W��̖��G����")]
    private float _invincibleTimeOfDamaged = 2;
    /// <summary>
    /// ��_���[�W�ɂ���Ė��G��Ԃ� (true = ���G���, false = �ʏ���)
    /// </summary>
    private bool _isInvincibleOfDamaged = false;
    /// <summary>
    /// ��_���[�W�ɂ�閳�G��Ԍo�ߎ��ԃJ�E���g
    /// </summary>
    private float _elapsedTimeInvOfDamaged = 0;


    /// <summary>
    /// ���E�̈ړ�
    /// </summary>
    /// <param name="move"></param>
    private void Move(float move)
    {
        // �ړ������̌v�Z

        // �Q�[���I�u�W�F�N�g�ɃX�s�[�h��^����

        // �����������ɃX�v���C�g�𔽓]
    }


    /// <summary>
    /// �U���A�N�V�����̊J�n
    /// </summary>
    private void Attack()
    {
        // �U���p�̓����蔻����o��(�A�j���[�V�������g���Ɗy)
    }
    

    /// <summary>
    /// �v���C���[�̍U������ɓG���q�b�g�������ɌĂ΂��A���̓G�̃_���[�W�������Ă�
    /// </summary>
    public void OnHitAttack(SampleEmemyBase enemy)
    {
        // �����̓G���Q�Ƃ��G�̃_���[�W�����֐����Ă�
    }

    
    /// <summary>
    /// �G�̍U�����v���C���[�Ƀq�b�g�����Ƃ��ɌĂ΂��A�v���C���[�̓_���[�W���󂯂�
    /// </summary>
    public void AddDamage(int damage = 1)
    {
        // ���G��ԂȂ�_���[�W���󂯂Ȃ�

        // �����̃_���[�W���v���C���[�ɗ^����

        // ���C�t��0�ȉ��ɂȂ����ꍇ�A���S���̏������Ă�

        // �����łȂ���Ζ��G���Ԃɓ���
    }


    /// <summary>
    /// ���t���[���Ă΂��A�v���C���[�̖��G���Ԃ��Ǘ�
    /// </summary>
    private void Invincible()
    {
        // ���G��ԂłȂ���Ώ������Ȃ�

        // �O�t���[������̌o�ߎ��Ԃ��J�E���g

        // �g�[�^���̌o�ߎ��Ԃ����G���Ԃ𒴂����疳�G��Ԃ�����
    }


    /// <summary>
    /// �v���C���[�����S�����Ƃ��ɌĂ΂��A���S���������Ă�
    /// </summary>
    private void Die()
    {
        // �Q�[���I�[�o�[�����Ȃǂ��Ă�
    }
}
