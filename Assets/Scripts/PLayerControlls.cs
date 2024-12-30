//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/PLayerControlls.inputactions
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

public partial class @PLayerControlls: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PLayerControlls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PLayerControlls"",
    ""maps"": [
        {
            ""name"": ""Character"",
            ""id"": ""9fb6a0c8-2b97-4402-aff4-f3004e7a3235"",
            ""actions"": [
                {
                    ""name"": ""Attack"",
                    ""type"": ""Button"",
                    ""id"": ""df6751ac-5c40-472c-8240-3b3ef22a2cbb"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""f35cddab-bf0c-4d02-9af7-a40f6f5a95e3"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Aim"",
                    ""type"": ""Value"",
                    ""id"": ""d94834a3-663a-47f1-902d-2a8790f5cba0"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""UltimateAttack"",
                    ""type"": ""Button"",
                    ""id"": ""0327e6f9-23de-4e0d-ae15-793fa34ef0b6"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Dash"",
                    ""type"": ""Button"",
                    ""id"": ""a03309ee-b4a2-4f47-b22e-b7f9b529c698"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""FAttack"",
                    ""type"": ""Button"",
                    ""id"": ""b75f4c5d-53c8-443c-93be-f9903893d14d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Shoot"",
                    ""type"": ""Button"",
                    ""id"": ""267b7df5-bda9-4ad8-960d-3cd8949b74ce"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Heal"",
                    ""type"": ""Button"",
                    ""id"": ""05978e88-02f7-4084-9de0-a92b5d355eec"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""40810948-130d-4555-9def-65ce00fe7649"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""32dbf1a2-7620-4b08-8775-c2bdbdf57dda"",
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
                    ""id"": ""efd76f78-8997-413a-aa48-3d234616056b"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""40392138-7a97-48fe-8597-f730f4a82be1"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""c1843456-32aa-4de9-953f-a763b752f521"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""be3a214b-96d8-4d30-b771-33dbad764c57"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""9039a686-d000-47a6-9f04-f50f7a859bd9"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Aim"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bcccbaa5-61f6-45fa-8385-d2bb14d6cb79"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""UltimateAttack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8b3cde75-8589-44f7-acd5-2b46be606d7a"",
                    ""path"": ""<Keyboard>/ctrl"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Dash"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2dd00652-839a-41d3-8ca3-757496a79916"",
                    ""path"": ""<Keyboard>/f"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""FAttack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1b2466ab-b9ad-4155-9c67-7cc3533dedd2"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9d2b2ff8-da82-4334-b039-29e261fbc7f2"",
                    ""path"": ""<Keyboard>/1"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Heal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Character
        m_Character = asset.FindActionMap("Character", throwIfNotFound: true);
        m_Character_Attack = m_Character.FindAction("Attack", throwIfNotFound: true);
        m_Character_Movement = m_Character.FindAction("Movement", throwIfNotFound: true);
        m_Character_Aim = m_Character.FindAction("Aim", throwIfNotFound: true);
        m_Character_UltimateAttack = m_Character.FindAction("UltimateAttack", throwIfNotFound: true);
        m_Character_Dash = m_Character.FindAction("Dash", throwIfNotFound: true);
        m_Character_FAttack = m_Character.FindAction("FAttack", throwIfNotFound: true);
        m_Character_Shoot = m_Character.FindAction("Shoot", throwIfNotFound: true);
        m_Character_Heal = m_Character.FindAction("Heal", throwIfNotFound: true);
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

    // Character
    private readonly InputActionMap m_Character;
    private List<ICharacterActions> m_CharacterActionsCallbackInterfaces = new List<ICharacterActions>();
    private readonly InputAction m_Character_Attack;
    private readonly InputAction m_Character_Movement;
    private readonly InputAction m_Character_Aim;
    private readonly InputAction m_Character_UltimateAttack;
    private readonly InputAction m_Character_Dash;
    private readonly InputAction m_Character_FAttack;
    private readonly InputAction m_Character_Shoot;
    private readonly InputAction m_Character_Heal;
    public struct CharacterActions
    {
        private @PLayerControlls m_Wrapper;
        public CharacterActions(@PLayerControlls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Attack => m_Wrapper.m_Character_Attack;
        public InputAction @Movement => m_Wrapper.m_Character_Movement;
        public InputAction @Aim => m_Wrapper.m_Character_Aim;
        public InputAction @UltimateAttack => m_Wrapper.m_Character_UltimateAttack;
        public InputAction @Dash => m_Wrapper.m_Character_Dash;
        public InputAction @FAttack => m_Wrapper.m_Character_FAttack;
        public InputAction @Shoot => m_Wrapper.m_Character_Shoot;
        public InputAction @Heal => m_Wrapper.m_Character_Heal;
        public InputActionMap Get() { return m_Wrapper.m_Character; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(CharacterActions set) { return set.Get(); }
        public void AddCallbacks(ICharacterActions instance)
        {
            if (instance == null || m_Wrapper.m_CharacterActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_CharacterActionsCallbackInterfaces.Add(instance);
            @Attack.started += instance.OnAttack;
            @Attack.performed += instance.OnAttack;
            @Attack.canceled += instance.OnAttack;
            @Movement.started += instance.OnMovement;
            @Movement.performed += instance.OnMovement;
            @Movement.canceled += instance.OnMovement;
            @Aim.started += instance.OnAim;
            @Aim.performed += instance.OnAim;
            @Aim.canceled += instance.OnAim;
            @UltimateAttack.started += instance.OnUltimateAttack;
            @UltimateAttack.performed += instance.OnUltimateAttack;
            @UltimateAttack.canceled += instance.OnUltimateAttack;
            @Dash.started += instance.OnDash;
            @Dash.performed += instance.OnDash;
            @Dash.canceled += instance.OnDash;
            @FAttack.started += instance.OnFAttack;
            @FAttack.performed += instance.OnFAttack;
            @FAttack.canceled += instance.OnFAttack;
            @Shoot.started += instance.OnShoot;
            @Shoot.performed += instance.OnShoot;
            @Shoot.canceled += instance.OnShoot;
            @Heal.started += instance.OnHeal;
            @Heal.performed += instance.OnHeal;
            @Heal.canceled += instance.OnHeal;
        }

        private void UnregisterCallbacks(ICharacterActions instance)
        {
            @Attack.started -= instance.OnAttack;
            @Attack.performed -= instance.OnAttack;
            @Attack.canceled -= instance.OnAttack;
            @Movement.started -= instance.OnMovement;
            @Movement.performed -= instance.OnMovement;
            @Movement.canceled -= instance.OnMovement;
            @Aim.started -= instance.OnAim;
            @Aim.performed -= instance.OnAim;
            @Aim.canceled -= instance.OnAim;
            @UltimateAttack.started -= instance.OnUltimateAttack;
            @UltimateAttack.performed -= instance.OnUltimateAttack;
            @UltimateAttack.canceled -= instance.OnUltimateAttack;
            @Dash.started -= instance.OnDash;
            @Dash.performed -= instance.OnDash;
            @Dash.canceled -= instance.OnDash;
            @FAttack.started -= instance.OnFAttack;
            @FAttack.performed -= instance.OnFAttack;
            @FAttack.canceled -= instance.OnFAttack;
            @Shoot.started -= instance.OnShoot;
            @Shoot.performed -= instance.OnShoot;
            @Shoot.canceled -= instance.OnShoot;
            @Heal.started -= instance.OnHeal;
            @Heal.performed -= instance.OnHeal;
            @Heal.canceled -= instance.OnHeal;
        }

        public void RemoveCallbacks(ICharacterActions instance)
        {
            if (m_Wrapper.m_CharacterActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(ICharacterActions instance)
        {
            foreach (var item in m_Wrapper.m_CharacterActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_CharacterActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public CharacterActions @Character => new CharacterActions(this);
    public interface ICharacterActions
    {
        void OnAttack(InputAction.CallbackContext context);
        void OnMovement(InputAction.CallbackContext context);
        void OnAim(InputAction.CallbackContext context);
        void OnUltimateAttack(InputAction.CallbackContext context);
        void OnDash(InputAction.CallbackContext context);
        void OnFAttack(InputAction.CallbackContext context);
        void OnShoot(InputAction.CallbackContext context);
        void OnHeal(InputAction.CallbackContext context);
    }
}
