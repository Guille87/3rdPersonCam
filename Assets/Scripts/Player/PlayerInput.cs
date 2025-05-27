using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    public Vector2 movement { get; private set; }
    public bool isRunning { get; private set; }
    Controls controls;

    void Awake()
    {
        controls = new Controls();
        controls.Player.Run.performed += _ => isRunning = true;
        controls.Player.Run.canceled += _ => isRunning = false;
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
