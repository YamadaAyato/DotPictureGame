using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Enemy : MonoBehaviour
{
    [SerializeField] public BattlePlayer _player;
    [SerializeField] public EnemyStutsData _stutsData;

    public string _enemyName;
    public int _currentHp;
    public int _currentAtk;
    public int _currentDef;
    

    private void Awake()
    {
        _enemyName = _stutsData.characterName;
        _currentHp = _stutsData.maxHp;
        _currentAtk = _stutsData.atk;
        _currentDef = _stutsData.def;
    }

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    /// <summary>
    /// �v���C���[�ւ̍U��
    /// </summary>
    public virtual void AttackOnPlayer()
    {
        _player.TakeDamage(_currentAtk);
        Debug.Log($"�v���C���[�ɍU���I");
    }

    /// <summary>
    /// �v���C���[����_���[�W���󂯂鏈��
    /// </summary>
    /// <param name="damage"�v���C���[����n�����_���[�W�ϐ�></param>
    public virtual void TakeDamage(int damage)
    {
        //�f�B�t�F���X�͂��l��������������ŕt����������

        _currentHp -= damage;
        Debug.Log($"{_enemyName}��{damage}�_���[�W�󂯂�");

        if (_currentHp <= 0)
        {
            Die();
        }
    }

    /// <summary>
    /// Enemy�̎��S���ɌĂ΂��
    /// </summary>
    public virtual void Die()
    {
        Debug.Log($"{_enemyName}�͓|�ꂽ");
        gameObject.SetActive(false);
    }
}
