using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputHandler : MonoBehaviour
{  
    public Vector2 RawMovementInput { get; private set; }
    public int NormInputX { get; private set; }
    public int NormInputY { get; private set; }

    public void OnMoveInput(InputAction.CallbackContext context)
    {
        //read value of the player input and assigns it to variable
        RawMovementInput = context.ReadValue<Vector2>();
        //converts the raw input to an integer of either -1 or 1
        //if wanting to add controller support later
        NormInputX = (int)(RawMovementInput * Vector2.right).normalized.x;
        NormInputY = (int)(RawMovementInput * Vector2.up).normalized.y;
    }

    public void OnJumpInput(InputAction.CallbackContext context)
    {

    }
}
