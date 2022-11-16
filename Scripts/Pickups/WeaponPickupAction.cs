using UnityEngine;

[CreateAssetMenu(fileName = "New Pickup", menuName = "Pickups/Weapon Pickup")]
public class WeaponPickupAction : PickupAction
{
    public WeaponData weaponToAdd = null;

    public override void DoPickupAction(GameObject target)
    {
        target.GetComponent<PlayerEquipment>().AddWeapon(weaponToAdd);
    }
}
