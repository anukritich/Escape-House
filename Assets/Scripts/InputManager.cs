using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Rendering;

public class InputManager : MonoBehaviour
   
{
    private PlayerInput playerInput;
    public PlayerInput .OnFootActions onFoot;   
    private PlayerMotor motor;
    private PlayerLook Look;
   
    void Awake()
    {
        playerInput=new PlayerInput ();
        onFoot = playerInput.OnFoot;
        motor = GetComponent<PlayerMotor>();
        Look = GetComponent<PlayerLook>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        motor.ProcessMove(onFoot.Movement.ReadValue<Vector2>());
    }
    private void LateUpdate()
    {
        Look.ProcessLook(onFoot.Look.ReadValue<Vector2>());
    }
    private void OnEnable()
    {
        onFoot.Enable();
    }
    private void OnDisable()
    {
        onFoot.Disable();
    }
}
