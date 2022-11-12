using UnityEngine;

public class PlayerLookAtMouse : MonoBehaviour
{
    [HideInInspector]
    public Vector3 raycastHitPoint;

    private void LateUpdate()
    {
        Ray cameraRay = Camera.main.ScreenPointToRay(Input.mousePosition);
        Plane groundPlane = new Plane(Vector3.up, Vector3.zero);
        float rayLength;

        if (groundPlane.Raycast(cameraRay, out rayLength))
        {
            raycastHitPoint = cameraRay.GetPoint(rayLength);
            Debug.DrawLine(cameraRay.origin, raycastHitPoint, Color.blue);

            transform.LookAt(new Vector3(raycastHitPoint.x, transform.position.y, raycastHitPoint.z));
        }
    }
}
