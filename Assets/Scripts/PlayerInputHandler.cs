using System.Collections;
using System.Collections.Generic;
using System.Linq; 
using UnityEngine;
using UnityEngine.InputSystem;
using static UnityEngine.InputSystem.InputAction;

public class PlayerInputHandler : MonoBehaviour
{


    private PlayerInput playerInput;
    private PlayerController car;


    private void Awake()
    {
        playerInput = GetComponent<PlayerInput>();
        var cars = FindObjectsOfType<PlayerController>();
        var index = playerInput.playerIndex;
        car = cars.FirstOrDefault(m => m.GetPlayerIndex() == index);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnSteer(CallbackContext context)
    {
        if (car == null) return;
        car.UpdateSteer(context.ReadValue<float>());
    }
    public void OnAccelerate(CallbackContext context)
    {
        if (car == null) return;
        car.UpdateAccelerate(context.ReadValue<float>());
    }
    public void OnChangeCamera(CallbackContext context)
    {
        if (car == null) return;
        car.UpdateCamera();

    }
}
