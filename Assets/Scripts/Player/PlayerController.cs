using UnityEngine;
using System.Collections;

//RigidBody2Dを要求
[RequireComponent(typeof(Rigidbody2D))]

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float _moveSpeed = 3f;  // 移動速度

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
    /// プレイヤーの移動
    /// </summary>
    private void Move()
    {
        ////キー入力の取得
        //float horizontal = Input.GetAxisRaw("Horizontal");
        //float vartical = Input.GetAxisRaw("Vertical");

        ////移動方向
        //Vector3 move = new Vector3(horizontal, vartical, 0).normalized;

        ////実際の移動
        //_playerRb.velocity = move * _moveSpeed;


        //移動していないときに実行
        if (!_isMoving)
        {
            Vector3 input = new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"), 0);

            //縦横どちらかの移動を優先して斜め移動を禁止
            if (input.x != 0)
            {
                input.y = 0;
            }

            if (input != Vector3.zero)
            {
                //今の位置と入力を足して移動先を計算
                Vector3 targetPosition = transform.position + input.normalized;
                StartCoroutine(MoveToGrid(targetPosition));
            }

        }
    }

    private IEnumerator MoveToGrid(Vector3 target)
    {

        _isMoving = true;

        //自分の位置が目的の位置についていない間繰り返す
        while (transform.position != target)
        {
            //目的の位置まで_moveSpeed * Time.deltaTimeで移動
            transform.position = Vector3.MoveTowards(transform.position, target, _moveSpeed * Time.deltaTime);
            //毎フレーム実行
            yield return null;
        }

        // ズレ補正
        transform.position = target; 
        _isMoving = false;
    }
}