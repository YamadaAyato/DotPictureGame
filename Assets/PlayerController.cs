using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]

public class PlayerContrller : MonoBehaviour
{
    [SerializeField,Header("�ړ����x")] private float _moveSpeed = 1f;

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
    /// �v���C���[�̈ړ�
    /// </summary>
    private void Move()
    {
        //�L�[���͂̎擾
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vartical = Input.GetAxisRaw("Vertical");

        //�ړ�����
        Vector3 move = new Vector3(horizontal, vartical, 0).normalized;

        //���ۂ̈ړ�
        _playerRb.velocity = move * _moveSpeed;
    }
}
