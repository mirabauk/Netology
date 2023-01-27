//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.4.4
//     from Assets/DZHeroInput.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @DZHeroInput : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @DZHeroInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""DZHeroInput"",
    ""maps"": [
        {
            ""name"": ""DZHeroControls"",
            ""id"": ""81c8bae2-f0e0-45c9-a3cc-b84f355e9e8b"",
            ""actions"": [
                {
                    ""name"": ""HeroMovement"",
                    ""type"": ""Value"",
                    ""id"": ""27840f15-b6f3-4b04-a66a-48343fd48297"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""HeroJump"",
                    ""type"": ""Button"",
                    ""id"": ""8e060ac0-cc3c-4be7-b207-8db7d28eef71"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""HeroAttack"",
                    ""type"": ""Button"",
                    ""id"": ""e8aea5e5-a8d2-4ded-9b4e-875cd35bbae1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""HeroRotate"",
                    ""type"": ""Value"",
                    ""id"": ""51f12ef4-d3ef-485d-94e1-ae0e57466ac3"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Fbutton"",
                    ""type"": ""Button"",
                    ""id"": ""fa85a7fc-5c45-4a7a-a3a8-a47cb00a1935"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Ctrlbutton"",
                    ""type"": ""Button"",
                    ""id"": ""c6527338-8efc-4793-a5fb-348e9eb234eb"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""23917bbe-5aa0-494a-9388-2ca74a5cfafc"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HeroMovement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""85f280ef-57a3-4933-a261-3d1256f31927"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HeroMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""b00a52f7-d92f-4aa5-8086-8c9f6fb06942"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HeroMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""86749719-fca7-4d24-a946-73c4f492b5b3"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HeroMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""bbbf696d-4831-4d6d-96ca-854aa4d5cc08"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HeroMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""69d6fc49-21b9-46d7-9ee3-f810bfa45ad5"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HeroJump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3e320458-6085-42c9-a94f-0a3e2789d63a"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HeroAttack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""3d6e2f4d-a5b3-4aa8-9fcf-420c16196a59"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HeroRotate"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""0e66d3fd-d7f6-4c8d-80be-b516417a6c90"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HeroRotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""1eb2bfbb-c94f-4782-bfaf-873a99120de0"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HeroRotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""efa32263-d007-4f3a-9e4b-bc32e9e5d9bb"",
                    ""path"": ""<Keyboard>/f"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Fbutton"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b63949ec-bfdc-4684-b969-010b277de158"",
                    ""path"": ""<Keyboard>/leftCtrl"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Ctrlbutton"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // DZHeroControls
        m_DZHeroControls = asset.FindActionMap("DZHeroControls", throwIfNotFound: true);
        m_DZHeroControls_HeroMovement = m_DZHeroControls.FindAction("HeroMovement", throwIfNotFound: true);
        m_DZHeroControls_HeroJump = m_DZHeroControls.FindAction("HeroJump", throwIfNotFound: true);
        m_DZHeroControls_HeroAttack = m_DZHeroControls.FindAction("HeroAttack", throwIfNotFound: true);
        m_DZHeroControls_HeroRotate = m_DZHeroControls.FindAction("HeroRotate", throwIfNotFound: true);
        m_DZHeroControls_Fbutton = m_DZHeroControls.FindAction("Fbutton", throwIfNotFound: true);
        m_DZHeroControls_Ctrlbutton = m_DZHeroControls.FindAction("Ctrlbutton", throwIfNotFound: true);
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
    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }
    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // DZHeroControls
    private readonly InputActionMap m_DZHeroControls;
    private IDZHeroControlsActions m_DZHeroControlsActionsCallbackInterface;
    private readonly InputAction m_DZHeroControls_HeroMovement;
    private readonly InputAction m_DZHeroControls_HeroJump;
    private readonly InputAction m_DZHeroControls_HeroAttack;
    private readonly InputAction m_DZHeroControls_HeroRotate;
    private readonly InputAction m_DZHeroControls_Fbutton;
    private readonly InputAction m_DZHeroControls_Ctrlbutton;
    public struct DZHeroControlsActions
    {
        private @DZHeroInput m_Wrapper;
        public DZHeroControlsActions(@DZHeroInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @HeroMovement => m_Wrapper.m_DZHeroControls_HeroMovement;
        public InputAction @HeroJump => m_Wrapper.m_DZHeroControls_HeroJump;
        public InputAction @HeroAttack => m_Wrapper.m_DZHeroControls_HeroAttack;
        public InputAction @HeroRotate => m_Wrapper.m_DZHeroControls_HeroRotate;
        public InputAction @Fbutton => m_Wrapper.m_DZHeroControls_Fbutton;
        public InputAction @Ctrlbutton => m_Wrapper.m_DZHeroControls_Ctrlbutton;
        public InputActionMap Get() { return m_Wrapper.m_DZHeroControls; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(DZHeroControlsActions set) { return set.Get(); }
        public void SetCallbacks(IDZHeroControlsActions instance)
        {
            if (m_Wrapper.m_DZHeroControlsActionsCallbackInterface != null)
            {
                @HeroMovement.started -= m_Wrapper.m_DZHeroControlsActionsCallbackInterface.OnHeroMovement;
                @HeroMovement.performed -= m_Wrapper.m_DZHeroControlsActionsCallbackInterface.OnHeroMovement;
                @HeroMovement.canceled -= m_Wrapper.m_DZHeroControlsActionsCallbackInterface.OnHeroMovement;
                @HeroJump.started -= m_Wrapper.m_DZHeroControlsActionsCallbackInterface.OnHeroJump;
                @HeroJump.performed -= m_Wrapper.m_DZHeroControlsActionsCallbackInterface.OnHeroJump;
                @HeroJump.canceled -= m_Wrapper.m_DZHeroControlsActionsCallbackInterface.OnHeroJump;
                @HeroAttack.started -= m_Wrapper.m_DZHeroControlsActionsCallbackInterface.OnHeroAttack;
                @HeroAttack.performed -= m_Wrapper.m_DZHeroControlsActionsCallbackInterface.OnHeroAttack;
                @HeroAttack.canceled -= m_Wrapper.m_DZHeroControlsActionsCallbackInterface.OnHeroAttack;
                @HeroRotate.started -= m_Wrapper.m_DZHeroControlsActionsCallbackInterface.OnHeroRotate;
                @HeroRotate.performed -= m_Wrapper.m_DZHeroControlsActionsCallbackInterface.OnHeroRotate;
                @HeroRotate.canceled -= m_Wrapper.m_DZHeroControlsActionsCallbackInterface.OnHeroRotate;
                @Fbutton.started -= m_Wrapper.m_DZHeroControlsActionsCallbackInterface.OnFbutton;
                @Fbutton.performed -= m_Wrapper.m_DZHeroControlsActionsCallbackInterface.OnFbutton;
                @Fbutton.canceled -= m_Wrapper.m_DZHeroControlsActionsCallbackInterface.OnFbutton;
                @Ctrlbutton.started -= m_Wrapper.m_DZHeroControlsActionsCallbackInterface.OnCtrlbutton;
                @Ctrlbutton.performed -= m_Wrapper.m_DZHeroControlsActionsCallbackInterface.OnCtrlbutton;
                @Ctrlbutton.canceled -= m_Wrapper.m_DZHeroControlsActionsCallbackInterface.OnCtrlbutton;
            }
            m_Wrapper.m_DZHeroControlsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @HeroMovement.started += instance.OnHeroMovement;
                @HeroMovement.performed += instance.OnHeroMovement;
                @HeroMovement.canceled += instance.OnHeroMovement;
                @HeroJump.started += instance.OnHeroJump;
                @HeroJump.performed += instance.OnHeroJump;
                @HeroJump.canceled += instance.OnHeroJump;
                @HeroAttack.started += instance.OnHeroAttack;
                @HeroAttack.performed += instance.OnHeroAttack;
                @HeroAttack.canceled += instance.OnHeroAttack;
                @HeroRotate.started += instance.OnHeroRotate;
                @HeroRotate.performed += instance.OnHeroRotate;
                @HeroRotate.canceled += instance.OnHeroRotate;
                @Fbutton.started += instance.OnFbutton;
                @Fbutton.performed += instance.OnFbutton;
                @Fbutton.canceled += instance.OnFbutton;
                @Ctrlbutton.started += instance.OnCtrlbutton;
                @Ctrlbutton.performed += instance.OnCtrlbutton;
                @Ctrlbutton.canceled += instance.OnCtrlbutton;
            }
        }
    }
    public DZHeroControlsActions @DZHeroControls => new DZHeroControlsActions(this);
    public interface IDZHeroControlsActions
    {
        void OnHeroMovement(InputAction.CallbackContext context);
        void OnHeroJump(InputAction.CallbackContext context);
        void OnHeroAttack(InputAction.CallbackContext context);
        void OnHeroRotate(InputAction.CallbackContext context);
        void OnFbutton(InputAction.CallbackContext context);
        void OnCtrlbutton(InputAction.CallbackContext context);
    }
}
