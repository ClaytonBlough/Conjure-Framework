using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
    public Transform player;
    public Vector3 followOffset = Vector3.zero;

    private void LateUpdate()
    {
        transform.position = new Vector3(player.position.x, followOffset.y, player.position.z + followOffset.z);
    }
}
