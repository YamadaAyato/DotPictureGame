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
    /// エネミーからダメージを受ける処理
    /// </summary>
    /// <param name="damage"エネミーから渡されるダメージ変数></param>
    public void TakeDamage(int damage)
    {
        //ディフェンス力を考慮した処理を後で付け足したい

        _currentHp -= damage;
        Debug.Log($"プレイヤーは{damage}ダメージ受けた");

        if (_currentHp <= 0)
        {
            Die();
        }
    }

    /// <summary>
    /// プレイヤーの死亡時に呼ばれる
    /// </summary>
    public void Die()
    {
        Debug.Log("プレイヤーは倒れた");
        gameObject.SetActive(false);
    }
}
