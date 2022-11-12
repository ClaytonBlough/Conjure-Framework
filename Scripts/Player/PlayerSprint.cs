using UnityEngine;

[RequireComponent(typeof(PlayerMovement))]
public class PlayerSprint : MonoBehaviour
{

    private PlayerMovement playerMovementScript = null;
    public float playerSprintMovementSpeed = 8.0f;

    private void Awake()
    {
        playerMovementScript = GetComponent<PlayerMovement>();
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            playerMovementScript.playerCurrentMovementSpeed = playerSprintMovementSpeed;
        }

        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            playerMovementScript.playerCurrentMovementSpeed = playerMovementScript.playerBaseMovementSpeed;
        }
    }
}
