using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Range Weapon Data", menuName = "Item Data/Ranged Weapon Data")]
public class RangedWeaponData : WeaponData
{
    // 1.) If you want add or remove an ammo type for your game
    // Edit the AmmunitionType script and this will automatically update.
    // 2.) This is set to 0 and casted as an AmmunitionType so that it always
    // grabs the first option by default no matter how you edit the base types.
    public AmmunitionType ammunitionType = (AmmunitionType)0;

    [Header("Ranged Weapon Stats")]
    public int projectiles = 1;
    public int capacity = 20;
    public enum RecoilType { Gradual, Instant };
    public RecoilType recoilType = RecoilType.Gradual;
    public float accuracy = 3f;
    public enum ReloadType { Magazine, OneAtATime };
    public ReloadType reloadType = ReloadType.Magazine;
    public float reloadTime = 2f;
    public string chosenAmmoType;

    [Header("Ranged Weapon Audio")]
    public AudioClip reloadStart = null;
    public AudioClip reloadLoop = null;
    public AudioClip reloadFinish = null;
}
