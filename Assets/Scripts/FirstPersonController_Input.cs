using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(FirstPersonController))]
public class FirstPersonController_Input : MonoBehaviour
{
    FirstPersonController controller;

    private NewInput input;
    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<FirstPersonController>();
        //Cursor.lockState = CursorLockMode.Locked;
        //Cursor.visible = false;
        input = new NewInput();
        input.Enable();
    }

    // Update is called once per frame
    void Update()
    {
    }
    private void FixedUpdate()
    {
        Vector2 inputValue = input.Player.Movimiento.ReadValue<Vector2>();

        controller.Move(new Vector2(inputValue.x, inputValue.y), Time.fixedDeltaTime);
    }
    private void LateUpdate()
    {
        Vector2 lookInputValue = input.Player.Vista.ReadValue<Vector2>();
        controller.Look(new Vector2(lookInputValue.x * Time.fixedDeltaTime, lookInputValue.y * Time.fixedDeltaTime));
    }
}
