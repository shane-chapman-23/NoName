using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Player state machine class is a variable that holds a reference to our current state, a function to initialize our current state and a function to change our state
public class PlayerStateMachine
{
    public PlayerState CurrentState { get; private set; }

    //Initializes our starting state
    public void Initialize(PlayerState startingState)
    {
        CurrentState = startingState;
        CurrentState.Enter();
    }

    //Changes State
    public void ChangeState(PlayerState newState)
    {
        CurrentState.Exit();
        CurrentState = newState;
        CurrentState.Enter();
    }
}
