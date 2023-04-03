using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInAirState : PlayerState
{

    private int xInput;
    private bool isGrounded;
    

    public PlayerInAirState(Player player, PlayerStateMachine stateMachine, PlayerData playerData, string animBoolName) : base(player, stateMachine, playerData, animBoolName)
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

        xInput = player.InputHandler.NormInputX;

        if(isGrounded && player.CurrentVelocity.y < 0.01f){
            stateMachine.ChangeState(player.LandState);
        } else {
            player.CheckIfShouldFlip(xInput);
            player.SetVelocityX(playerData.movementVelocity * xInput);

            player.Anim.SetFloat("yVelocity", player.CurrentVelocity.y);
            player.Anim.SetFloat("xVelocity", Mathf.Abs(player.CurrentVelocity.x));
        }
    }
    //called every fixed update
    public override void PhysicsUpdate()
    {
        base.PhysicsUpdate();
    }
}

