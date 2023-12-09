using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class TopDownCharacterController : MonoBehaviour
{
    //event => 외부에서는 호출하지 못하게 막는다
    public event Action<Vector2> OnMoveEvent;
    public event Action<Vector2> OnLookEvent;
    public event Action OnAttackEvent;

    private float _timeSinceLastAttack = float.MaxValue;
    protected bool IsAttacking {  get; set; }

    protected CharacterStatsHandler Stats { get; private set; }
    protected virtual void Awake()
    {
        
    }
    protected virtual void Start()
    {
        Stats = GetComponent<CharacterStatsHandler>();
        Debug.Log(Stats.ToString());
    }
    
    protected virtual void Update()
    {
        HandleAttackDelay();
    }

    private void HandleAttackDelay()
    {
        if (Stats.CurrentStates.attackSO == null)
            return;
        //if (Stats == null || Stats.CurrentStates == null || Stats.CurrentStates.attackSO == null)
        //{
        //    // Stats 또는 CurrentStates 또는 attackSO가 null인 경우 처리
        //    return;
        //}

        if (_timeSinceLastAttack <= Stats.CurrentStates.attackSO.delay) 
        {
            _timeSinceLastAttack += Time.deltaTime;
        }
        
        if (IsAttacking && _timeSinceLastAttack > Stats.CurrentStates.attackSO.delay)
        {
            _timeSinceLastAttack = 0;
            CallAttackEvent();
        }
    }

    public void CallMoveEvent(Vector2 direction)
    {
        OnMoveEvent?.Invoke(direction);
    }

    public void CallLookEvent(Vector2 direction)
    {
        OnLookEvent?.Invoke(direction);
    }
    public void CallAttackEvent()
    {
        OnAttackEvent?.Invoke();
    }
}
