using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGroundedState : PlayerState
{
    //Move
    protected int xInput;
    //Jump
    private bool jumpInput;

    public PlayerGroundedState(Player player, PlayerStateMachine stateMachine, PlayerData playerData, string animBoolName) : base(player, stateMachine, playerData, animBoolName)
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
        //sets ionput variable to input handlers movement input
        xInput = player.InputHandler.NormInputX;
        jumpInput = player.InputHandler.JumpInput;
        //change to jump state when jump button is pushed
        if(jumpInput){
            //after JumpInput variable is used, set to false
            player.InputHandler.UseJumpInput();
            stateMachine.ChangeState(player.JumpState);
        }
    }
    //called every fixed update
    public override void PhysicsUpdate()
    {
        base.PhysicsUpdate();
    }

}
