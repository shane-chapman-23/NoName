using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAbilityState : PlayerState
{
    protected bool isAbilityDone;

    private bool isGrounded;

    public PlayerAbilityState(Player player, PlayerStateMachine stateMachine, PlayerData playerData, string animBoolName) : base(player, stateMachine, playerData, animBoolName)
    {
        
    }

    //function called on state enter and physics update
    public override void DoChecks()
    {
        base.DoChecks();

        isGrounded = player.CheckIfGrounded();
    }
    //called on state enter
    public override void Enter()
    {
        base.Enter();

        isAbilityDone = false;
    }
    //called on state exit
    public override void Exit()
    {
        base.Exit();
    }
    //called every frame
    public override void LogicUpdate()
    {
        base.LogicUpdate();

        if(isAbilityDone){
            if(isGrounded && player.CurrentVelocity.y < 0.01f){
                stateMachine.ChangeState(player.IdleState);
            } else {
                stateMachine.ChangeState(player.InAirState);
            }
        }
    }
    //called every fixed update
    public override void PhysicsUpdate()
    {
        base.PhysicsUpdate();
    }
}
