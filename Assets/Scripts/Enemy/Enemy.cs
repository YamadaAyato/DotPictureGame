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
    /// プレイヤーへの攻撃
    /// </summary>
    public virtual void AttackOnPlayer()
    {
        _player.TakeDamage(_currentAtk);
        Debug.Log($"プレイヤーに攻撃！");
    }

    /// <summary>
    /// プレイヤーからダメージを受ける処理
    /// </summary>
    /// <param name="damage"プレイヤーから渡されるダメージ変数></param>
    public virtual void TakeDamage(int damage)
    {
        //ディフェンス力を考慮した処理を後で付け足したい

        _currentHp -= damage;
        Debug.Log($"{_enemyName}は{damage}ダメージ受けた");

        if (_currentHp <= 0)
        {
            Die();
        }
    }

    /// <summary>
    /// Enemyの死亡時に呼ばれる
    /// </summary>
    public virtual void Die()
    {
        Debug.Log($"{_enemyName}は倒れた");
        gameObject.SetActive(false);
    }
}
