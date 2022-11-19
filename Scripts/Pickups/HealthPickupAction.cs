using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Pickup", menuName = "Pickups/Health Pickup")]
public class HealthPickupAction : PickupAction
{
    [Tooltip("Positive values heal, negative values deal damage.")]
    [SerializeField] private float healthAmount = 10.0f;

    public override void DoPickupAction(GameObject target)
    {
        target.GetComponent<DamageableObject>().currentHealth += healthAmount;
    }
}
