using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveState : PlayerGroundedState
{
    public PlayerMoveState(Player player, PlayerStateMachine stateMachine, PlayerData playerData, string animBoolName) : base(player, stateMachine, playerData, animBoolName)
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

        player.CheckIfShouldFlip(xInput);

        player.SetVelocityX(playerData.movementVelocity * xInput);

        if(xInput == 0){
            stateMachine.ChangeState(player.IdleState);
        }
    }
    //called every fixed update
    public override void PhysicsUpdate()
    {
        base.PhysicsUpdate();
    }
}
