using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitBehaviour : MonoBehaviour
{
    protected UnitBaseModel model;
    public StateMachine StateMachine { get; protected set; }

    public IdleState IdleState { get; protected set; }
    public MovementState MovementState { get; protected set; }
    private void Awake()
    {
        InitStates();
    }
    private void Update()
    {
        StateMachine.CurrentState.GameUpdate();
    }
    private void InitStates()
    {
        IdleState = new IdleState(this);
        MovementState = new MovementState(this);
        StateMachine = new StateMachine(IdleState);
    }
    public void Init(UnitBaseModel model)
    {
        this.model = model;
    }
    public void StartMoving()
    {
        Invoke("Move", Random.Range(1, 5));
    }
    private void Move()
    {
        StateMachine.ChangeState(MovementState);
    }
}
