// GENERATED AUTOMATICALLY FROM 'Assets/Inputs/CarInput.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @CarInput : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @CarInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""CarInput"",
    ""maps"": [
        {
            ""name"": ""Driving"",
            ""id"": ""b4f90eb1-f904-446a-84ec-6798817e3f5a"",
            ""actions"": [
                {
                    ""name"": ""Steering"",
                    ""type"": ""PassThrough"",
                    ""id"": ""641892f4-0226-4b4a-9104-a2e457fd8b55"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Accel"",
                    ""type"": ""Button"",
                    ""id"": ""7a433aa2-c140-460c-b18e-173a56859bfa"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Braking"",
                    ""type"": ""Button"",
                    ""id"": ""81c903f5-9e7b-47a3-8320-8ba6f0a60e4a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""2a473e2f-6914-4399-a020-f7960dc95e4f"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Steering"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""d6129b92-66f1-47f0-983e-42ce07343a0d"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Steering"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""6bc83682-7da2-4b00-aff0-67284e42522d"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Steering"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""b51c46d9-3520-413b-99f8-2e9161a8053a"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Accel"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""8e34010a-45cb-4891-96e9-77b1a2c43b2c"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Accel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""82f6e44c-c248-4ade-b76f-c1ffdc3106aa"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Accel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""bb269fb3-338b-4bbf-abb7-f0f06294e480"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Braking"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Driving
        m_Driving = asset.FindActionMap("Driving", throwIfNotFound: true);
        m_Driving_Steering = m_Driving.FindAction("Steering", throwIfNotFound: true);
        m_Driving_Accel = m_Driving.FindAction("Accel", throwIfNotFound: true);
        m_Driving_Braking = m_Driving.FindAction("Braking", throwIfNotFound: true);
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

    // Driving
    private readonly InputActionMap m_Driving;
    private IDrivingActions m_DrivingActionsCallbackInterface;
    private readonly InputAction m_Driving_Steering;
    private readonly InputAction m_Driving_Accel;
    private readonly InputAction m_Driving_Braking;
    public struct DrivingActions
    {
        private @CarInput m_Wrapper;
        public DrivingActions(@CarInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Steering => m_Wrapper.m_Driving_Steering;
        public InputAction @Accel => m_Wrapper.m_Driving_Accel;
        public InputAction @Braking => m_Wrapper.m_Driving_Braking;
        public InputActionMap Get() { return m_Wrapper.m_Driving; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(DrivingActions set) { return set.Get(); }
        public void SetCallbacks(IDrivingActions instance)
        {
            if (m_Wrapper.m_DrivingActionsCallbackInterface != null)
            {
                @Steering.started -= m_Wrapper.m_DrivingActionsCallbackInterface.OnSteering;
                @Steering.performed -= m_Wrapper.m_DrivingActionsCallbackInterface.OnSteering;
                @Steering.canceled -= m_Wrapper.m_DrivingActionsCallbackInterface.OnSteering;
                @Accel.started -= m_Wrapper.m_DrivingActionsCallbackInterface.OnAccel;
                @Accel.performed -= m_Wrapper.m_DrivingActionsCallbackInterface.OnAccel;
                @Accel.canceled -= m_Wrapper.m_DrivingActionsCallbackInterface.OnAccel;
                @Braking.started -= m_Wrapper.m_DrivingActionsCallbackInterface.OnBraking;
                @Braking.performed -= m_Wrapper.m_DrivingActionsCallbackInterface.OnBraking;
                @Braking.canceled -= m_Wrapper.m_DrivingActionsCallbackInterface.OnBraking;
            }
            m_Wrapper.m_DrivingActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Steering.started += instance.OnSteering;
                @Steering.performed += instance.OnSteering;
                @Steering.canceled += instance.OnSteering;
                @Accel.started += instance.OnAccel;
                @Accel.performed += instance.OnAccel;
                @Accel.canceled += instance.OnAccel;
                @Braking.started += instance.OnBraking;
                @Braking.performed += instance.OnBraking;
                @Braking.canceled += instance.OnBraking;
            }
        }
    }
    public DrivingActions @Driving => new DrivingActions(this);
    public interface IDrivingActions
    {
        void OnSteering(InputAction.CallbackContext context);
        void OnAccel(InputAction.CallbackContext context);
        void OnBraking(InputAction.CallbackContext context);
    }
}
