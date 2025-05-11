using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

namespace JTools
{
    public class ImpactComponent_Input_NewInputSystem : ImpactComponent_Input
    {
        [Header("Input Action Asset")]
        public InputActionAsset inputActions; // Assign your InputActionAsset in the inspector

        // Action Names (must match the names in your InputActionAsset)
        [Header("Action Names")]
        public string lookAction = "Look";
        public string moveAction = "Move";
        public string jumpAction = "Jump";
        public string sprintAction = "Sprint";
        public string crouchAction = "Crouch";
        public string primaryAction = "Primary";
        public string secondaryAction = "Secondary";
        public string menuAction = "Menu";
        public string interactAction = "Interact";

        // InputAction references
        private InputAction look;
        private InputAction move;
        private InputAction jump;
        private InputAction sprint;
        private InputAction crouch;
        private InputAction primary;
        private InputAction secondary;
        private InputAction menu;
        private InputAction interact;


        private void OnEnable()
        {
            // Enable all input actions
            look = inputActions.FindAction(lookAction);
            move = inputActions.FindAction(moveAction);
            jump = inputActions.FindAction(jumpAction);
            sprint = inputActions.FindAction(sprintAction);
            crouch = inputActions.FindAction(crouchAction);
            primary = inputActions.FindAction(primaryAction);
            secondary = inputActions.FindAction(secondaryAction);
            menu = inputActions.FindAction(menuAction);
            interact = inputActions.FindAction(interactAction);

            look.Enable();
            move.Enable();
            jump.Enable();
            sprint.Enable();
            crouch.Enable();
            primary.Enable();
            secondary.Enable();
            menu.Enable();
            interact.Enable();
        }

        private void OnDisable()
        {
            // Disable all input actions
            look.Disable();
            move.Disable();
            jump.Disable();
            sprint.Disable();
            crouch.Disable();
            primary.Disable();
            secondary.Disable();
            menu.Disable();
            interact.Disable();
        }

        public override void Controls()
        {
            // Mouse Look
            inputData.mouseInput = look.ReadValue<Vector2>();

            // Movement (WASD/Gamepad Stick)
            Vector2 moveInput = move.ReadValue<Vector2>();
            inputData.motionInput = new Vector3(moveInput.x, 0f, moveInput.y).normalized;

            // Jump
            inputData.pressedJump = jump.WasPressedThisFrame();
            inputData.holdingJump = jump.IsPressed();
            inputData.releasedJump = jump.WasReleasedThisFrame();

            // Sprint
            inputData.pressedSprint = sprint.WasPressedThisFrame();
            inputData.holdingSprint = sprint.IsPressed();
            inputData.releasedSprint = sprint.WasReleasedThisFrame();

            // Crouch
            inputData.pressedCrouch = crouch.WasPressedThisFrame();
            inputData.holdingCrouch = crouch.IsPressed();
            inputData.releasedCrouch = crouch.WasReleasedThisFrame();

            // Primary (e.g., Left Mouse / Gamepad Trigger)
            inputData.pressedPrimary = primary.WasPressedThisFrame();
            inputData.holdingPrimary = primary.IsPressed();
            inputData.releasedPrimary = primary.WasReleasedThisFrame();

            // Secondary (e.g., Right Mouse / Gamepad Trigger)
            inputData.pressedSecondary = secondary.WasPressedThisFrame();
            inputData.holdingSecondary = secondary.IsPressed();
            inputData.releasedSecondary = secondary.WasReleasedThisFrame();

            // Menu (e.g., Escape / Gamepad Start)
            inputData.pressedMenu = menu.WasPressedThisFrame();
            inputData.holdingMenu = menu.IsPressed();
            inputData.releasedMenu = menu.WasReleasedThisFrame();

            // Interact (e.g., E / Gamepad Button)
            inputData.pressedInteract = interact.WasPressedThisFrame();
            inputData.holdingInteract = interact.IsPressed();
            inputData.releasedInteract = interact.WasReleasedThisFrame();
        }
    }
}