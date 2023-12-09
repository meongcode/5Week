using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum StatsChangeType
{
    Add,
    Multiple,
    Override,
}

[Serializable]
public class CharacterStats // 데이터 단위로만 사용 할 예정이라 MonoBehaviour 삭제
{
    public StatsChangeType statsChangeType;
    [Range(1,100)] public int maxHealth;
    [Range(1f, 20f)] public float speed;

    //공격 데이터 
    public AttackSO attackSO;
}
