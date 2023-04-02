using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerIdleState : PlayerGroundedState
{
    public PlayerIdleState(Player player, PlayerStateMachine stateMachine, PlayerData playerData, string animBoolName) : base(player, stateMachine, playerData, animBoolName)
    {
        
    }
    //function called on state enter and physics update
    public override void DoChecks()
    {
        base.DoChecks();
    }
    //called on state enter
    public override void Enter()
    {
        base.Enter();
        player.SetVelocityX(0f);
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
        //when movement input exists, state is changed to move
        if(xInput != 0){
            stateMachine.ChangeState(player.MoveState);
        }
    }
    //called every fixed update
    public override void PhysicsUpdate()
    {
        base.PhysicsUpdate();
    }
}
