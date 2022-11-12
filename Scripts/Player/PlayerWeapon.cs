using UnityEngine;

[RequireComponent(typeof(PlayerLookAtMouse))]
[RequireComponent(typeof(PlayerEquipment))]
public class PlayerWeapon : MonoBehaviour
{

    private PlayerLookAtMouse playerLookAtMouse = null;
    private PlayerEquipment playerEquipment = null;

    public Transform weaponAttackSpawnPoint = null;
    private float currentWeaponAttackTime = 0.0f;

    private void Awake()
    {
        playerLookAtMouse = GetComponent<PlayerLookAtMouse>();
        playerEquipment = GetComponent<PlayerEquipment>();
    }

    private void OnEnable()
    {
        PlayerEquipment.weaponSwitchDelegate += WeaponDataReset;
    }

    private void OnDisable()
    {
        PlayerEquipment.weaponSwitchDelegate -= WeaponDataReset;
    }

    private void Update()
    {
        if (playerEquipment.playerCurrentWeapon != null)
        {
            if (Input.GetMouseButton(0))
            {
                currentWeaponAttackTime -= Time.deltaTime;

                if (currentWeaponAttackTime <= 0.0f)
                {
                    WeaponAttack();
                }
            }

            if (Input.GetMouseButtonUp(0))
            {
                currentWeaponAttackTime = 0.0f;
            }
        }
    }

    public void WeaponDataReset()
    {
        currentWeaponAttackTime = 0.0f;
    }

    public void WeaponAttack()
    {
        currentWeaponAttackTime = playerEquipment.playerCurrentWeapon.weaponAttackRate;

        RaycastHit hit;
        Vector3 heightCorrection = new Vector3(playerLookAtMouse.raycastHitPoint.x, weaponAttackSpawnPoint.position.y, playerLookAtMouse.raycastHitPoint.z);
        Vector3 attackDirection = (heightCorrection - weaponAttackSpawnPoint.position).normalized;

        if(Physics.Raycast(weaponAttackSpawnPoint.position, attackDirection, out hit, playerEquipment.playerCurrentWeapon.weaponAttackRange))
        {
            if (hit.collider.gameObject.CompareTag("Damageable"))
            {
                hit.collider.gameObject.GetComponent<DamageableObject>().TakeDamage(playerEquipment.playerCurrentWeapon.weaponDamage, weaponAttackSpawnPoint.position - hit.point, hit.point);
            }
            Debug.DrawRay(weaponAttackSpawnPoint.position, attackDirection * hit.distance, Color.red, 2f);
        }
        else
        {
            Debug.DrawRay(weaponAttackSpawnPoint.position, attackDirection * playerEquipment.playerCurrentWeapon.weaponAttackRange, Color.yellow, 2f);
        }
    }
}
