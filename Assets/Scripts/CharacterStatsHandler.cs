using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterStatsHandler : MonoBehaviour
{
    [SerializeField] private CharacterStats baseState;
    public CharacterStats CurrentStates {  get; private set; }
    public List<CharacterStats> statsModifiers = new List<CharacterStats>();

    private void Awake()
    {
        UpdateCharacterStats();
    }

    private void UpdateCharacterStats()
    {
        AttackSO attackSO = null;
        if (baseState.attackSO != null)
        {
            attackSO = Instantiate(baseState.attackSO);
        }

        CurrentStates = new CharacterStats { attackSO = attackSO };
        //TODO
        CurrentStates.statsChangeType = baseState.statsChangeType;
        CurrentStates.maxHealth = baseState.maxHealth;
        CurrentStates.speed = baseState.speed;
    }
}
