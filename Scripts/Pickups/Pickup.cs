using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider))]
public class Pickup : MonoBehaviour
{
    public PickupAction pickupAction = null;

    private SphereCollider interactionCollider = null;

    private void Awake()
    {
        interactionCollider = GetComponent<SphereCollider>();
    }

    private void Start()
    {
        interactionCollider.isTrigger = true;
        UpdatePickupValues();
    }

    private void OnEnable()
    {
        UpdatePickupValues();
    }

    private void UpdatePickupValues()
    {
        interactionCollider.radius = pickupAction.pickupRange;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag(pickupAction.pickupTargetTag))
        {
            pickupAction.DoPickupAction(other.gameObject);
            Destroy(gameObject);
        }
    }
}
