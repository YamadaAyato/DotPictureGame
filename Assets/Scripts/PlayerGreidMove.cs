using UnityEngine;
using System.Collections;

//RigidBody2D��v��
[RequireComponent(typeof(Rigidbody2D))]

public class PlayerGridMover : MonoBehaviour
{
    [SerializeField] private float _moveSpeed = 3f;  // �ړ����x

    private bool _isMoving = false;
    private Rigidbody2D _rb;

    void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
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
        //�ړ����Ă��Ȃ��Ƃ��Ɏ��s
        if (!_isMoving)
        {
            Vector3 input = new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"), 0);

            //�c���ǂ��炩�̈ړ���D�悵�Ď΂߈ړ����֎~
            if (input.x != 0)
            {
                input.y = 0;
            }

            if (input != Vector3.zero)
            {
                //���̈ʒu�Ɠ��͂𑫂��Ĉړ�����v�Z
                Vector3 targetPosition = transform.position + input.normalized;
                StartCoroutine(MoveToGrid(targetPosition));
            }

        }
    }

    private IEnumerator MoveToGrid(Vector3 target)
    {

        _isMoving = true;

        //�����̈ʒu���ړI�̈ʒu�ɂ��Ă��Ȃ��ԌJ��Ԃ�
        while (transform.position != target)
        {
            //�ړI�̈ʒu�܂�_moveSpeed * Time.deltaTime�ňړ�
            transform.position = Vector3.MoveTowards(transform.position, target, _moveSpeed * Time.deltaTime);
            //���t���[�����s
            yield return null;
        }

        // �Y���␳
        transform.position = target; 
        _isMoving = false;
    }
}