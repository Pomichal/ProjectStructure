using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class State
{
    protected UnitBehaviour unitBehaviour;
    public State(UnitBehaviour unitBehaviour)
    {
        this.unitBehaviour = unitBehaviour;
    }
    public abstract void Enter();
    public virtual void GameUpdate()
    {

    }
    public abstract void Exit();
}
