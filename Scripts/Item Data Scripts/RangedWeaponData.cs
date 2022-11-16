using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Weapon Data", menuName = "Weapon Data/Ranged Weapon")]
public class RangedWeaponData : WeaponData
{
    public AmmunitionType ammunitionType = AmmunitionType.Handgun32;

    [Header("Ranged Weapon Stats")]
    public int projectiles = 1;
    public int capacity = 20;
    public enum RecoilType { Gradual, Instant };
    public RecoilType recoilType = RecoilType.Gradual;
    public float accuracy = 3f;
    public enum ReloadType { AllAtOnce, PerBullet };
    public ReloadType reloadType = ReloadType.AllAtOnce;
    public float reloadTime = 2f;
    public string chosenAmmoType;

    [Header("Ranged Weapon Audio")]
    public AudioClip reloadStart = null;
    public AudioClip reloadLoop = null;
    public AudioClip reloadFinish = null;
}
