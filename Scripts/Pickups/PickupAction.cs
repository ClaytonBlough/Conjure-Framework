using UnityEngine;

public abstract class PickupAction : ScriptableObject
{
    [TagSelector] public string pickupTargetTag = "";
    public float pickupRange = 1f;

    public abstract void DoPickupAction(GameObject target);
}
