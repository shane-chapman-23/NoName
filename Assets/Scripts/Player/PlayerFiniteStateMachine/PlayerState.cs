using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerState
{
    protected Player player;
    protected PlayerStateMachine stateMachine;
    protected PlayerData playerData;

    protected float startTime;

    private string animBoolName;

    public PlayerState(Player player, PlayerStateMachine stateMachine, PlayerData playerData, string animBoolName)
    {
        this.player = player;
        this.stateMachine = stateMachine;
        this.playerData = playerData;
        this.animBoolName = animBoolName;
    }

    //Virtual functions can be overriden by classes that inherit from this class
    //called on state enter
    public virtual void Enter()
    {
        DoChecks();
        //setting the states animBoolname to true on enter
        player.Anim.SetBool(animBoolName, true);
        //setting start time of state
        startTime = Time.time;

        Debug.Log(animBoolName);
    }
    //called on state exit
    public virtual void Exit()
    {
       //setting the states animBoolname to false on exit
        player.Anim.SetBool(animBoolName, false);
    }
    //called every frame
    public virtual void LogicUpdate()
    {

    }
    //called every fixed update
    public virtual void PhysicsUpdate()
    {
        DoChecks();
    }
    //function called on state enter and physics update
    public virtual void DoChecks()
    {

    }
}
