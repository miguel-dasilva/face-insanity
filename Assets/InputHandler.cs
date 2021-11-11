// GENERATED AUTOMATICALLY FROM 'Assets/InputHandler.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @InputHandler : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputHandler()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputHandler"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""56e6d2ce-58c0-4e5f-8d01-217be04609dd"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""e5ee2557-9b2a-4ab4-a0dd-12b7ea5629b0"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""20c80f2e-df35-4c1a-a804-eec01fcdb910"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""SprintPressed"",
                    ""type"": ""Button"",
                    ""id"": ""5f196ed1-8379-4c55-b102-9819ca2de648"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Hold""
                },
                {
                    ""name"": ""SprintReleased"",
                    ""type"": ""Button"",
                    ""id"": ""3f4f04bc-4ee2-4179-8ad0-be369cd8dc28"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Hold""
                },
                {
                    ""name"": ""CrouchPressed"",
                    ""type"": ""Button"",
                    ""id"": ""e28031c2-891b-4e2d-a16e-bb5d4377e6b9"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Hold""
                },
                {
                    ""name"": ""CrouchReleased"",
                    ""type"": ""Button"",
                    ""id"": ""306760f1-8dc2-4c51-b294-016ea3ab2a21"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Hold""
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""9e4cfbd2-b5f8-4403-84e1-57fb4fcb5300"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""6e9f785c-651f-4e95-beed-544183798d99"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""keyboard"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""fd3769e3-6b53-49e5-afb3-a2f9167170fd"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""keyboard"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""5088eec3-3048-4f05-8d97-a091cb490daf"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""keyboard"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""2cb06afd-73c6-4be4-ac33-1935ea6b531d"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""keyboard"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""992c1ad0-5d01-43a4-a771-fc7ffefdda86"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f0a3bcb5-18c3-4cb7-922b-7306ecdba070"",
                    ""path"": ""<Keyboard>/shift"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SprintPressed"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""74ffd7b8-b895-4d6c-a3c6-a6d32ebe0ed9"",
                    ""path"": ""<Keyboard>/shift"",
                    ""interactions"": ""Press(behavior=1)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SprintReleased"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6fa50fad-bf61-42a2-a752-ce2c1fe5050a"",
                    ""path"": ""<Keyboard>/ctrl"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CrouchPressed"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""62864f48-1cc1-4a97-b24b-5d6d198e156e"",
                    ""path"": ""<Keyboard>/ctrl"",
                    ""interactions"": ""Press(behavior=1)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CrouchReleased"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""keyboard"",
            ""bindingGroup"": ""keyboard"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_Movement = m_Player.FindAction("Movement", throwIfNotFound: true);
        m_Player_Jump = m_Player.FindAction("Jump", throwIfNotFound: true);
        m_Player_SprintPressed = m_Player.FindAction("SprintPressed", throwIfNotFound: true);
        m_Player_SprintReleased = m_Player.FindAction("SprintReleased", throwIfNotFound: true);
        m_Player_CrouchPressed = m_Player.FindAction("CrouchPressed", throwIfNotFound: true);
        m_Player_CrouchReleased = m_Player.FindAction("CrouchReleased", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    // Player
    private readonly InputActionMap m_Player;
    private IPlayerActions m_PlayerActionsCallbackInterface;
    private readonly InputAction m_Player_Movement;
    private readonly InputAction m_Player_Jump;
    private readonly InputAction m_Player_SprintPressed;
    private readonly InputAction m_Player_SprintReleased;
    private readonly InputAction m_Player_CrouchPressed;
    private readonly InputAction m_Player_CrouchReleased;
    public struct PlayerActions
    {
        private @InputHandler m_Wrapper;
        public PlayerActions(@InputHandler wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_Player_Movement;
        public InputAction @Jump => m_Wrapper.m_Player_Jump;
        public InputAction @SprintPressed => m_Wrapper.m_Player_SprintPressed;
        public InputAction @SprintReleased => m_Wrapper.m_Player_SprintReleased;
        public InputAction @CrouchPressed => m_Wrapper.m_Player_CrouchPressed;
        public InputAction @CrouchReleased => m_Wrapper.m_Player_CrouchReleased;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovement;
                @Jump.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJump;
                @SprintPressed.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSprintPressed;
                @SprintPressed.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSprintPressed;
                @SprintPressed.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSprintPressed;
                @SprintReleased.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSprintReleased;
                @SprintReleased.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSprintReleased;
                @SprintReleased.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSprintReleased;
                @CrouchPressed.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCrouchPressed;
                @CrouchPressed.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCrouchPressed;
                @CrouchPressed.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCrouchPressed;
                @CrouchReleased.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCrouchReleased;
                @CrouchReleased.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCrouchReleased;
                @CrouchReleased.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCrouchReleased;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @SprintPressed.started += instance.OnSprintPressed;
                @SprintPressed.performed += instance.OnSprintPressed;
                @SprintPressed.canceled += instance.OnSprintPressed;
                @SprintReleased.started += instance.OnSprintReleased;
                @SprintReleased.performed += instance.OnSprintReleased;
                @SprintReleased.canceled += instance.OnSprintReleased;
                @CrouchPressed.started += instance.OnCrouchPressed;
                @CrouchPressed.performed += instance.OnCrouchPressed;
                @CrouchPressed.canceled += instance.OnCrouchPressed;
                @CrouchReleased.started += instance.OnCrouchReleased;
                @CrouchReleased.performed += instance.OnCrouchReleased;
                @CrouchReleased.canceled += instance.OnCrouchReleased;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);
    private int m_keyboardSchemeIndex = -1;
    public InputControlScheme keyboardScheme
    {
        get
        {
            if (m_keyboardSchemeIndex == -1) m_keyboardSchemeIndex = asset.FindControlSchemeIndex("keyboard");
            return asset.controlSchemes[m_keyboardSchemeIndex];
        }
    }
    public interface IPlayerActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnSprintPressed(InputAction.CallbackContext context);
        void OnSprintReleased(InputAction.CallbackContext context);
        void OnCrouchPressed(InputAction.CallbackContext context);
        void OnCrouchReleased(InputAction.CallbackContext context);
    }
}
