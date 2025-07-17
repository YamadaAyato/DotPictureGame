using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattlePlayer : MonoBehaviour
{
    [SerializeField] private int _maxHp;

    private int _currentHp;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    /// <summary>
    /// �G�l�~�[����_���[�W���󂯂鏈��
    /// </summary>
    /// <param name="damage"�G�l�~�[����n�����_���[�W�ϐ�></param>
    public void TakeDamage(int damage)
    {
        //�f�B�t�F���X�͂��l��������������ŕt����������

        _currentHp -= damage;
        Debug.Log($"�v���C���[��{damage}�_���[�W�󂯂�");

        if (_currentHp <= 0)
        {
            Die();
        }
    }

    /// <summary>
    /// �v���C���[�̎��S���ɌĂ΂��
    /// </summary>
    public void Die()
    {
        Debug.Log("�v���C���[�͓|�ꂽ");
        gameObject.SetActive(false);
    }
}
