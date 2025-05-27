using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    public Vector2 movement { get; private set; }
    Controls controls;

    void Awake()
    {
        controls = new Controls();
    }

    void OnEnable()
    {
        controls.Enable();
    }

    void OnDisable()
    {
        controls.Disable();
    }

    void Update()
    {
        ReadInput();
    }

    void ReadInput()
    {
        movement = controls.Player.Move.ReadValue<Vector2>();
    }
}
