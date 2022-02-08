using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementState : State
{
    private int waypointIndex = 0;
    public MovementState(UnitBehaviour unitBehaviour) : base(unitBehaviour)
    {
    }

    public override void Enter()
    {
        Debug.Log("Moving " + unitBehaviour.name);
    }
    public override void GameUpdate()
    {
        var targetWaypoint = App.levelManager.Waypoints[waypointIndex].position;
        unitBehaviour.transform.position = Vector3.MoveTowards(unitBehaviour.transform.position, targetWaypoint, 2 * Time.deltaTime);
        if (Vector3.Distance(unitBehaviour.transform.position, targetWaypoint) < 0.001f && waypointIndex < App.levelManager.Waypoints.Count - 1)
        {
            waypointIndex++;
        }
    }
    public override void Exit()
    {
    }
}
