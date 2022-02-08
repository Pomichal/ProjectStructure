using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdleState : State
{
    public IdleState(UnitBehaviour unitBehaviour) : base(unitBehaviour)
    {
    }

    public override void Enter()
    {
        Debug.Log("idle state enter");
        unitBehaviour.StartMoving();
    }

    public override void Exit()
    {
        Debug.Log("idle state exit");
    }
}
