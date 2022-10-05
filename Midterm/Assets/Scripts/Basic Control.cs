//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.4.3
//     from Assets/Scripts/Basic Control.inputactions
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

public partial class @BasicControl : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @BasicControl()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Basic Control"",
    ""maps"": [
        {
            ""name"": ""Bee"",
            ""id"": ""f2c4f535-dd24-497a-819f-1a2b4de8c739"",
            ""actions"": [
                {
                    ""name"": ""Shoot"",
                    ""type"": ""Button"",
                    ""id"": ""e753a024-c267-4b81-9bd9-cc5d9a67de7b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""98fd47a9-aa61-4864-9614-f05a8d9123e9"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""New action map"",
            ""id"": ""e654bca2-89e4-4c25-96f1-b0b267c59695"",
            ""actions"": [
                {
                    ""name"": ""New action"",
                    ""type"": ""Button"",
                    ""id"": ""24f09481-c53b-46d5-a64f-23c91bd38a09"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""4f1aec75-946f-481e-9804-997f09134096"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""New action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Bee
        m_Bee = asset.FindActionMap("Bee", throwIfNotFound: true);
        m_Bee_Shoot = m_Bee.FindAction("Shoot", throwIfNotFound: true);
        // New action map
        m_Newactionmap = asset.FindActionMap("New action map", throwIfNotFound: true);
        m_Newactionmap_Newaction = m_Newactionmap.FindAction("New action", throwIfNotFound: true);
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

    // Bee
    private readonly InputActionMap m_Bee;
    private IBeeActions m_BeeActionsCallbackInterface;
    private readonly InputAction m_Bee_Shoot;
    public struct BeeActions
    {
        private @BasicControl m_Wrapper;
        public BeeActions(@BasicControl wrapper) { m_Wrapper = wrapper; }
        public InputAction @Shoot => m_Wrapper.m_Bee_Shoot;
        public InputActionMap Get() { return m_Wrapper.m_Bee; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(BeeActions set) { return set.Get(); }
        public void SetCallbacks(IBeeActions instance)
        {
            if (m_Wrapper.m_BeeActionsCallbackInterface != null)
            {
                @Shoot.started -= m_Wrapper.m_BeeActionsCallbackInterface.OnShoot;
                @Shoot.performed -= m_Wrapper.m_BeeActionsCallbackInterface.OnShoot;
                @Shoot.canceled -= m_Wrapper.m_BeeActionsCallbackInterface.OnShoot;
            }
            m_Wrapper.m_BeeActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Shoot.started += instance.OnShoot;
                @Shoot.performed += instance.OnShoot;
                @Shoot.canceled += instance.OnShoot;
            }
        }
    }
    public BeeActions @Bee => new BeeActions(this);

    // New action map
    private readonly InputActionMap m_Newactionmap;
    private INewactionmapActions m_NewactionmapActionsCallbackInterface;
    private readonly InputAction m_Newactionmap_Newaction;
    public struct NewactionmapActions
    {
        private @BasicControl m_Wrapper;
        public NewactionmapActions(@BasicControl wrapper) { m_Wrapper = wrapper; }
        public InputAction @Newaction => m_Wrapper.m_Newactionmap_Newaction;
        public InputActionMap Get() { return m_Wrapper.m_Newactionmap; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(NewactionmapActions set) { return set.Get(); }
        public void SetCallbacks(INewactionmapActions instance)
        {
            if (m_Wrapper.m_NewactionmapActionsCallbackInterface != null)
            {
                @Newaction.started -= m_Wrapper.m_NewactionmapActionsCallbackInterface.OnNewaction;
                @Newaction.performed -= m_Wrapper.m_NewactionmapActionsCallbackInterface.OnNewaction;
                @Newaction.canceled -= m_Wrapper.m_NewactionmapActionsCallbackInterface.OnNewaction;
            }
            m_Wrapper.m_NewactionmapActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Newaction.started += instance.OnNewaction;
                @Newaction.performed += instance.OnNewaction;
                @Newaction.canceled += instance.OnNewaction;
            }
        }
    }
    public NewactionmapActions @Newactionmap => new NewactionmapActions(this);
    public interface IBeeActions
    {
        void OnShoot(InputAction.CallbackContext context);
    }
    public interface INewactionmapActions
    {
        void OnNewaction(InputAction.CallbackContext context);
    }
}
