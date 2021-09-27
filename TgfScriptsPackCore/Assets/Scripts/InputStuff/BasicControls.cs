// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/TFG_SP/Input/BasicControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

namespace NoEyeInTea.InputStuff
{
    public class BasicControls : IInputActionCollection, IDisposable
    {
        public InputActionAsset asset { get; }
        public BasicControls()
        {
            asset = InputActionAsset.FromJson(@"{
    ""name"": ""BasicControls"",
    ""maps"": [
        {
            ""name"": ""Basic"",
            ""id"": ""2a101ca9-0aa2-4abf-a804-99bed8950757"",
            ""actions"": [
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""6362d7e1-02c8-4b3c-bcc7-ee792ec85dd0"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""Jump_Hold"",
                    ""type"": ""Button"",
                    ""id"": ""16d8e90c-e28c-45c6-8fba-86bec155b45d"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": ""Hold""
                },
                {
                    ""name"": ""Move"",
                    ""type"": ""PassThrough"",
                    ""id"": ""d88738bb-961d-4b0e-97f3-a8c703d3525f"",
                    ""expectedControlType"": """",
                    ""processors"": ""AxisDeadzone"",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Look"",
                    ""type"": ""PassThrough"",
                    ""id"": ""2337bf69-e688-4579-b00c-2f6cbad7956f"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Attack_Right"",
                    ""type"": ""Value"",
                    ""id"": ""2c2cdc89-33aa-4e8a-9d19-9e064d37bc16"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=1)""
                },
                {
                    ""name"": ""Attack_Left"",
                    ""type"": ""Value"",
                    ""id"": ""59502e88-b29e-473b-9822-4336a4107edc"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=1)""
                },
                {
                    ""name"": ""LockOn"",
                    ""type"": ""Button"",
                    ""id"": ""013667b8-538b-4d8a-8368-ca6f787ef20a"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": ""Press""
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""5b41ef51-894f-47bd-9f2b-1cf295c85b13"",
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
                    ""id"": ""dd4b6fb4-5e22-4981-858b-e84b8b11f7ab"",
                    ""path"": ""<XInputController>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""062c7d56-d588-4f87-8fbe-ac9d18bde5f5"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump_Hold"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""836eee42-46af-4b57-89ea-d45d5f981e8b"",
                    ""path"": ""<XInputController>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump_Hold"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""5fe9dc62-20fd-4d16-a9b0-fcfec9a26eb4"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""325790ee-d38b-46a2-9c51-123b2dd787e9"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""57f4e675-c7ff-4e39-98ef-675de72cbdaa"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""5d326d8d-d7e1-48c1-a783-18e9314799a8"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""2da08327-855f-4670-bf42-a9981717548e"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""d59c710e-df02-4389-b98f-bccab9924d6a"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""05c6d9a5-6e31-40f1-9b86-4d7805a1cc7a"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""142c09e3-04a2-4241-8a5f-eb4fd4bb8fe6"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""96af31bf-740b-41ae-8d83-17aab53dde00"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""bf560ea9-054c-4d6b-9099-9e29cdbbcfaa"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""7a6221b0-9713-4829-85ff-382892443d4e"",
                    ""path"": ""<XInputController>/leftStick"",
                    ""interactions"": """",
                    ""processors"": ""AxisDeadzone"",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""60627506-a06b-41ed-a735-19f88eea1343"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": ""ScaleVector2(x=0.2,y=0.2),InvertVector2(invertX=false,invertY=false)"",
                    ""groups"": """",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0cb997f0-2984-4338-a05c-da574ee79859"",
                    ""path"": ""<XInputController>/rightStick"",
                    ""interactions"": """",
                    ""processors"": ""AxisDeadzone,InvertVector2"",
                    ""groups"": """",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""580565ca-c80e-4a75-b565-c5cf5fe082e0"",
                    ""path"": ""<XInputController>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Attack_Right"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""865c1574-3130-4a89-a09c-a246a0f6760b"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Attack_Right"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5cc3893a-62d3-4230-8f2f-86497dbe8285"",
                    ""path"": ""<Mouse>/middleButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LockOn"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f29a123c-03ee-4269-90ea-363f0dab1fcf"",
                    ""path"": ""<XInputController>/leftStickPress"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LockOn"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""937ab920-8b53-4e35-a176-78d6096500df"",
                    ""path"": ""<XInputController>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Attack_Left"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6361bd08-0667-46db-8d35-4a2b2499ef0f"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Attack_Left"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""UI"",
            ""id"": ""79ad1194-dc09-4410-ad6d-a8fafe449054"",
            ""actions"": [
                {
                    ""name"": ""Point"",
                    ""type"": ""PassThrough"",
                    ""id"": ""92741741-507e-4e88-8e92-160ca8f6e395"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Click"",
                    ""type"": ""PassThrough"",
                    ""id"": ""40b16782-7bf7-40c6-8132-541725852aae"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Scroll"",
                    ""type"": ""PassThrough"",
                    ""id"": ""30228c90-995a-41bb-99ec-e8bac2008048"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Pause"",
                    ""type"": ""Button"",
                    ""id"": ""3c66032e-9009-4d5b-9920-7e7d78f818ed"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": ""Press""
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""7c0a8739-5264-4fe6-8021-89393660e0d8"",
                    ""path"": ""<VirtualMouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Click"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""11c1e75b-7958-42f6-b449-5bdd8c262c33"",
                    ""path"": ""<VirtualMouse>/scroll"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Scroll"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e8affe11-67e6-4e3f-8dae-49e03d569d76"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Basic"",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4aad2bbe-baaf-486f-bd5e-6074e05bb1b9"",
                    ""path"": ""<Keyboard>/tab"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Basic"",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3965fb0d-fcbf-4b43-ba8d-34f61fc1247a"",
                    ""path"": ""<XInputController>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Basic"",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b120ceb7-f192-4b7c-b73b-a5e1240d81ee"",
                    ""path"": ""<XInputController>/select"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Basic"",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Basic"",
            ""bindingGroup"": ""Basic"",
            ""devices"": []
        }
    ]
}");
            // Basic
            m_Basic = asset.FindActionMap("Basic", throwIfNotFound: true);
            m_Basic_Jump = m_Basic.FindAction("Jump", throwIfNotFound: true);
            m_Basic_Jump_Hold = m_Basic.FindAction("Jump_Hold", throwIfNotFound: true);
            m_Basic_Move = m_Basic.FindAction("Move", throwIfNotFound: true);
            m_Basic_Look = m_Basic.FindAction("Look", throwIfNotFound: true);
            m_Basic_Attack_Right = m_Basic.FindAction("Attack_Right", throwIfNotFound: true);
            m_Basic_Attack_Left = m_Basic.FindAction("Attack_Left", throwIfNotFound: true);
            m_Basic_LockOn = m_Basic.FindAction("LockOn", throwIfNotFound: true);
            // UI
            m_UI = asset.FindActionMap("UI", throwIfNotFound: true);
            m_UI_Point = m_UI.FindAction("Point", throwIfNotFound: true);
            m_UI_Click = m_UI.FindAction("Click", throwIfNotFound: true);
            m_UI_Scroll = m_UI.FindAction("Scroll", throwIfNotFound: true);
            m_UI_Pause = m_UI.FindAction("Pause", throwIfNotFound: true);
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

        // Basic
        private readonly InputActionMap m_Basic;
        private IBasicActions m_BasicActionsCallbackInterface;
        private readonly InputAction m_Basic_Jump;
        private readonly InputAction m_Basic_Jump_Hold;
        private readonly InputAction m_Basic_Move;
        private readonly InputAction m_Basic_Look;
        private readonly InputAction m_Basic_Attack_Right;
        private readonly InputAction m_Basic_Attack_Left;
        private readonly InputAction m_Basic_LockOn;
        public struct BasicActions
        {
            private @BasicControls m_Wrapper;
            public BasicActions(@BasicControls wrapper) { m_Wrapper = wrapper; }
            public InputAction @Jump => m_Wrapper.m_Basic_Jump;
            public InputAction @Jump_Hold => m_Wrapper.m_Basic_Jump_Hold;
            public InputAction @Move => m_Wrapper.m_Basic_Move;
            public InputAction @Look => m_Wrapper.m_Basic_Look;
            public InputAction @Attack_Right => m_Wrapper.m_Basic_Attack_Right;
            public InputAction @Attack_Left => m_Wrapper.m_Basic_Attack_Left;
            public InputAction @LockOn => m_Wrapper.m_Basic_LockOn;
            public InputActionMap Get() { return m_Wrapper.m_Basic; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(BasicActions set) { return set.Get(); }
            public void SetCallbacks(IBasicActions instance)
            {
                if (m_Wrapper.m_BasicActionsCallbackInterface != null)
                {
                    @Jump.started -= m_Wrapper.m_BasicActionsCallbackInterface.OnJump;
                    @Jump.performed -= m_Wrapper.m_BasicActionsCallbackInterface.OnJump;
                    @Jump.canceled -= m_Wrapper.m_BasicActionsCallbackInterface.OnJump;
                    @Jump_Hold.started -= m_Wrapper.m_BasicActionsCallbackInterface.OnJump_Hold;
                    @Jump_Hold.performed -= m_Wrapper.m_BasicActionsCallbackInterface.OnJump_Hold;
                    @Jump_Hold.canceled -= m_Wrapper.m_BasicActionsCallbackInterface.OnJump_Hold;
                    @Move.started -= m_Wrapper.m_BasicActionsCallbackInterface.OnMove;
                    @Move.performed -= m_Wrapper.m_BasicActionsCallbackInterface.OnMove;
                    @Move.canceled -= m_Wrapper.m_BasicActionsCallbackInterface.OnMove;
                    @Look.started -= m_Wrapper.m_BasicActionsCallbackInterface.OnLook;
                    @Look.performed -= m_Wrapper.m_BasicActionsCallbackInterface.OnLook;
                    @Look.canceled -= m_Wrapper.m_BasicActionsCallbackInterface.OnLook;
                    @Attack_Right.started -= m_Wrapper.m_BasicActionsCallbackInterface.OnAttack_Right;
                    @Attack_Right.performed -= m_Wrapper.m_BasicActionsCallbackInterface.OnAttack_Right;
                    @Attack_Right.canceled -= m_Wrapper.m_BasicActionsCallbackInterface.OnAttack_Right;
                    @Attack_Left.started -= m_Wrapper.m_BasicActionsCallbackInterface.OnAttack_Left;
                    @Attack_Left.performed -= m_Wrapper.m_BasicActionsCallbackInterface.OnAttack_Left;
                    @Attack_Left.canceled -= m_Wrapper.m_BasicActionsCallbackInterface.OnAttack_Left;
                    @LockOn.started -= m_Wrapper.m_BasicActionsCallbackInterface.OnLockOn;
                    @LockOn.performed -= m_Wrapper.m_BasicActionsCallbackInterface.OnLockOn;
                    @LockOn.canceled -= m_Wrapper.m_BasicActionsCallbackInterface.OnLockOn;
                }
                m_Wrapper.m_BasicActionsCallbackInterface = instance;
                if (instance != null)
                {
                    @Jump.started += instance.OnJump;
                    @Jump.performed += instance.OnJump;
                    @Jump.canceled += instance.OnJump;
                    @Jump_Hold.started += instance.OnJump_Hold;
                    @Jump_Hold.performed += instance.OnJump_Hold;
                    @Jump_Hold.canceled += instance.OnJump_Hold;
                    @Move.started += instance.OnMove;
                    @Move.performed += instance.OnMove;
                    @Move.canceled += instance.OnMove;
                    @Look.started += instance.OnLook;
                    @Look.performed += instance.OnLook;
                    @Look.canceled += instance.OnLook;
                    @Attack_Right.started += instance.OnAttack_Right;
                    @Attack_Right.performed += instance.OnAttack_Right;
                    @Attack_Right.canceled += instance.OnAttack_Right;
                    @Attack_Left.started += instance.OnAttack_Left;
                    @Attack_Left.performed += instance.OnAttack_Left;
                    @Attack_Left.canceled += instance.OnAttack_Left;
                    @LockOn.started += instance.OnLockOn;
                    @LockOn.performed += instance.OnLockOn;
                    @LockOn.canceled += instance.OnLockOn;
                }
            }
        }
        public BasicActions @Basic => new BasicActions(this);

        // UI
        private readonly InputActionMap m_UI;
        private IUIActions m_UIActionsCallbackInterface;
        private readonly InputAction m_UI_Point;
        private readonly InputAction m_UI_Click;
        private readonly InputAction m_UI_Scroll;
        private readonly InputAction m_UI_Pause;
        public struct UIActions
        {
            private @BasicControls m_Wrapper;
            public UIActions(@BasicControls wrapper) { m_Wrapper = wrapper; }
            public InputAction @Point => m_Wrapper.m_UI_Point;
            public InputAction @Click => m_Wrapper.m_UI_Click;
            public InputAction @Scroll => m_Wrapper.m_UI_Scroll;
            public InputAction @Pause => m_Wrapper.m_UI_Pause;
            public InputActionMap Get() { return m_Wrapper.m_UI; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(UIActions set) { return set.Get(); }
            public void SetCallbacks(IUIActions instance)
            {
                if (m_Wrapper.m_UIActionsCallbackInterface != null)
                {
                    @Point.started -= m_Wrapper.m_UIActionsCallbackInterface.OnPoint;
                    @Point.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnPoint;
                    @Point.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnPoint;
                    @Click.started -= m_Wrapper.m_UIActionsCallbackInterface.OnClick;
                    @Click.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnClick;
                    @Click.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnClick;
                    @Scroll.started -= m_Wrapper.m_UIActionsCallbackInterface.OnScroll;
                    @Scroll.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnScroll;
                    @Scroll.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnScroll;
                    @Pause.started -= m_Wrapper.m_UIActionsCallbackInterface.OnPause;
                    @Pause.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnPause;
                    @Pause.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnPause;
                }
                m_Wrapper.m_UIActionsCallbackInterface = instance;
                if (instance != null)
                {
                    @Point.started += instance.OnPoint;
                    @Point.performed += instance.OnPoint;
                    @Point.canceled += instance.OnPoint;
                    @Click.started += instance.OnClick;
                    @Click.performed += instance.OnClick;
                    @Click.canceled += instance.OnClick;
                    @Scroll.started += instance.OnScroll;
                    @Scroll.performed += instance.OnScroll;
                    @Scroll.canceled += instance.OnScroll;
                    @Pause.started += instance.OnPause;
                    @Pause.performed += instance.OnPause;
                    @Pause.canceled += instance.OnPause;
                }
            }
        }
        public UIActions @UI => new UIActions(this);
        private int m_BasicSchemeIndex = -1;
        public InputControlScheme BasicScheme
        {
            get
            {
                if (m_BasicSchemeIndex == -1) m_BasicSchemeIndex = asset.FindControlSchemeIndex("Basic");
                return asset.controlSchemes[m_BasicSchemeIndex];
            }
        }
        public interface IBasicActions
        {
            void OnJump(InputAction.CallbackContext context);
            void OnJump_Hold(InputAction.CallbackContext context);
            void OnMove(InputAction.CallbackContext context);
            void OnLook(InputAction.CallbackContext context);
            void OnAttack_Right(InputAction.CallbackContext context);
            void OnAttack_Left(InputAction.CallbackContext context);
            void OnLockOn(InputAction.CallbackContext context);
        }
        public interface IUIActions
        {
            void OnPoint(InputAction.CallbackContext context);
            void OnClick(InputAction.CallbackContext context);
            void OnScroll(InputAction.CallbackContext context);
            void OnPause(InputAction.CallbackContext context);
        }
    }
}
