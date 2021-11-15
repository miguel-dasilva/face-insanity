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
                    ""name"": ""Interact"",
                    ""type"": ""Button"",
                    ""id"": ""b6e813ea-1380-4517-aac3-18e43093130d"",
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
                },
                {
                    ""name"": ""Continue"",
                    ""type"": ""Button"",
                    ""id"": ""4e64f187-8922-4177-878b-ac4ed1131385"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""CycleMask"",
                    ""type"": ""Value"",
                    ""id"": ""e80ed39d-f2ed-4e06-822d-ba26382574ba"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
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
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8c501cd2-45f0-409b-b2e3-605e36c9c887"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""keyboard"",
                    ""action"": ""Interact"",
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
                    ""groups"": ""keyboard"",
                    ""action"": ""SprintReleased"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6fa50fad-bf61-42a2-a752-ce2c1fe5050a"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""keyboard"",
                    ""action"": ""CrouchPressed"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d775d4e7-c2ab-4d54-a184-c035842a4be5"",
                    ""path"": ""<Keyboard>/enter"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""keyboard"",
                    ""action"": ""Continue"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""62864f48-1cc1-4a97-b24b-5d6d198e156e"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": ""Press(behavior=1)"",
                    ""processors"": """",
                    ""groups"": ""keyboard"",
                    ""action"": ""CrouchReleased"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d07d55bf-24b1-48d7-914c-2e4bf84f9bba"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""keyboard"",
                    ""action"": ""Continue"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ed3428c3-db43-43bc-b8d1-b3f933b0bfd4"",
                    ""path"": ""<Keyboard>/tab"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""keyboard"",
                    ""action"": ""CycleMask"",
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
        m_Player_Interact = m_Player.FindAction("Interact", throwIfNotFound: true);
        m_Player_SprintPressed = m_Player.FindAction("SprintPressed", throwIfNotFound: true);
        m_Player_SprintReleased = m_Player.FindAction("SprintReleased", throwIfNotFound: true);
        m_Player_CrouchPressed = m_Player.FindAction("CrouchPressed", throwIfNotFound: true);
        m_Player_CrouchReleased = m_Player.FindAction("CrouchReleased", throwIfNotFound: true);
        m_Player_Continue = m_Player.FindAction("Continue", throwIfNotFound: true);
        m_Player_CycleMask = m_Player.FindAction("CycleMask", throwIfNotFound: true);
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
    private readonly InputAction m_Player_Interact;
    private readonly InputAction m_Player_SprintPressed;
    private readonly InputAction m_Player_SprintReleased;
    private readonly InputAction m_Player_CrouchPressed;
    private readonly InputAction m_Player_CrouchReleased;
    private readonly InputAction m_Player_Continue;
    private readonly InputAction m_Player_CycleMask;
    public struct PlayerActions
    {
        private @InputHandler m_Wrapper;
        public PlayerActions(@InputHandler wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_Player_Movement;
        public InputAction @Jump => m_Wrapper.m_Player_Jump;
        public InputAction @Interact => m_Wrapper.m_Player_Interact;
        public InputAction @SprintPressed => m_Wrapper.m_Player_SprintPressed;
        public InputAction @SprintReleased => m_Wrapper.m_Player_SprintReleased;
        public InputAction @CrouchPressed => m_Wrapper.m_Player_CrouchPressed;
        public InputAction @CrouchReleased => m_Wrapper.m_Player_CrouchReleased;
        public InputAction @Continue => m_Wrapper.m_Player_Continue;
        public InputAction @CycleMask => m_Wrapper.m_Player_CycleMask;
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
                @Interact.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnInteract;
                @Interact.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnInteract;
                @Interact.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnInteract;
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
                @Continue.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnContinue;
                @Continue.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnContinue;
                @Continue.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnContinue;
                @CycleMask.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCycleMask;
                @CycleMask.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCycleMask;
                @CycleMask.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCycleMask;
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
                @Interact.started += instance.OnInteract;
                @Interact.performed += instance.OnInteract;
                @Interact.canceled += instance.OnInteract;
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
                @Continue.started += instance.OnContinue;
                @Continue.performed += instance.OnContinue;
                @Continue.canceled += instance.OnContinue;
                @CycleMask.started += instance.OnCycleMask;
                @CycleMask.performed += instance.OnCycleMask;
                @CycleMask.canceled += instance.OnCycleMask;
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
        void OnInteract(InputAction.CallbackContext context);
        void OnSprintPressed(InputAction.CallbackContext context);
        void OnSprintReleased(InputAction.CallbackContext context);
        void OnCrouchPressed(InputAction.CallbackContext context);
        void OnCrouchReleased(InputAction.CallbackContext context);
        void OnContinue(InputAction.CallbackContext context);
        void OnCycleMask(InputAction.CallbackContext context);
    }
}
