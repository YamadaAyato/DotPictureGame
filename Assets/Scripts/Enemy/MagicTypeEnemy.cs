using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagicTypeEnemy : Enemy
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void AttackOnPlayer()
    {
        _player.TakeDamage(_currentAtk);
        Debug.Log("���@�g���̓G���U�����@���������I");
        // �f�o�t�Ȃǒǉ����ʂ̎���������
    }
}
