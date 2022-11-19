using UnityEngine;

[CreateAssetMenu(fileName = "New Range Weapon Data", menuName = "Item Data/Ranged Weapon Data")]
public class RangedWeaponData : WeaponData
{
    // 1.) If you want add or remove an ammo type for your game
    // Edit the AmmunitionType script and this will automatically update.
    // 2.) This is set to 0 and casted as an AmmunitionType so that it always
    // grabs the first option by default no matter how you edit the base types.
    public AmmunitionType ammunitionType = (AmmunitionType)0;

    [Header("[Ranged Weapon] Base Stats")]
    public int projectiles = 1;
    public int capacity = 20;
    public float projectileRange = 100.0f;
    public enum RecoilType { AnimationCurve, Bloom };
    public RecoilType recoilType = RecoilType.AnimationCurve;
    public float accuracyMinBloomAngle = 1f;
    public float accuracyMaxBloomAngle = 8f;

    // TO-DO: Find a way to set a default straight-line curve.
    public AnimationCurve recoilAnimationCurve = null;

    public enum ReloadType { Magazine, OneAtATime };
    public ReloadType reloadType = ReloadType.Magazine;
    public float reloadTimeLength = 2f;

    // [Header("[Ranged Weapon] Fire Rate")]
    public enum FireModeType { SemiAutomatic, FullyAutomatic, BurstFire };
    [Tooltip("SemiAutomatic - Shoots one bullet per button press." +
    "\r\nFullyAutomatic - Shoots bullets while pressing down button." +
    "\r\nBurstFire - Shoots a barrage of projectiles.")]
    public FireModeType fireModeType = FireModeType.SemiAutomatic;

    [Header("[Ranged Weapon] Audio")]
    public AudioClip reloadStart = null;
    public AudioClip reloadLoop = null;
    public AudioClip reloadFinish = null;
}
