using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmorTypeEnemy : Enemy
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void TakeDamage(int damage)
    {
        int reducedDamage = Mathf.Max(0, damage - _currentDef);
        base.TakeDamage(reducedDamage);
    }
}
