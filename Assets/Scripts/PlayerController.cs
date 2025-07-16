using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]

public class PlayerContrller : MonoBehaviour
{
    [SerializeField,Header("移動速度")] private float _moveSpeed = 1f;

    Rigidbody2D _playerRb;

    void Awake()
    {
        _playerRb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Move();
    }

    /// <summary>
    /// プレイヤーの移動
    /// </summary>
    private void Move()
    {
        //キー入力の取得
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vartical = Input.GetAxisRaw("Vertical");

        //移動方向
        Vector3 move = new Vector3(horizontal, vartical, 0).normalized;

        //実際の移動
        _playerRb.velocity = move * _moveSpeed;
    }
}
