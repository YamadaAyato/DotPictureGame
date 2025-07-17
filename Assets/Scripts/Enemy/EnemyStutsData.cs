using UnityEngine;

[CreateAssetMenu(menuName = "Data/Create EnemyStatusData")]

public class EnemyStutsData : ScriptableObject
{
    public string characterName;
    public int maxHp;
    public int atk;
    public float speed;
    public int def;
}
