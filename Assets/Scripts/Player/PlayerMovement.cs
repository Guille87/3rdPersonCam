using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float moveSpeed;

    PlayerInput playerInput;
    CharacterController characterController;

    void Start()
    {
        playerInput = GetComponent<PlayerInput>();
        characterController = GetComponent<CharacterController>();
    }
    
    void Update()
    {
        MoveAndRotate();
    }

    void MoveAndRotate()
    {
        // Dirección de movimiento
        Vector3 movement = new Vector3(playerInput.movement.x, 0, playerInput.movement.y);

        // Translación horizontal del jugador
        characterController.Move(movement * moveSpeed * Time.deltaTime);

        // Rotación del jugador
        if (movement != Vector3.zero)
        {
            transform.rotation = Quaternion.LookRotation(movement);
        }
    }
}
