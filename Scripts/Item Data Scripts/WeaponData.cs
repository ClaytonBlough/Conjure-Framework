using UnityEngine;

public class WeaponData : ItemData
{
    [Header("Weapon Stats")]
    public float weaponDamage = 10.0f;
    public float weaponAttackRate = 1.0f;
    public float weaponAttackRange = 50.0f;

    [Header("Weapon Visuals")]
    public GameObject weaponModel = null;

    [Header("Weapon Sounds")]
    public AudioClip weaponAttackSound = null;
    public AudioClip weaponEquipSound = null;
    public AudioClip weaponUnequipSound = null;
}
