using System.Collections.Generic;
using UnityEngine;

public class PlayerEquipment : MonoBehaviour
{
    public WeaponData playerCurrentWeapon = null;
    public List<WeaponData> playerWeapons = new List<WeaponData>();
    public int playerWeaponIndex = 0;
    public Transform weaponModelSpawnPoint = null;

    private GameObject currentWeaponModel = null;

    public delegate void OnWeaponSwitchDelegate();
    public static OnWeaponSwitchDelegate weaponSwitchDelegate;

    private void Awake()
    {
        currentWeaponModel = Instantiate(playerWeapons[playerWeaponIndex].weaponModel, weaponModelSpawnPoint.position, weaponModelSpawnPoint.rotation, weaponModelSpawnPoint);
        currentWeaponModel.transform.localScale = Vector3.one;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            WeaponCycle(0);
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            WeaponCycle(1);
        }
    }

    public void AddWeapon(WeaponData newWeaponData)
    {
        bool weaponFound = false;

        foreach(WeaponData playerWeaponData in playerWeapons)
        {
            if(playerWeaponData.itemName == newWeaponData.itemName)
            {
                weaponFound = true;
                // You could add some code here to add ammo to a weapon that already exists.
                // You would need to add a currentAmmunitionCount variable in WeaponData.
                break;
            }
        }

        if(!weaponFound)
        {
            playerWeapons.Add(newWeaponData);
            Debug.Log("Added " + newWeaponData.itemName + " to players weapon list!");
        }
    }

    public void WeaponCycle(int direction = 0)
    {
        switch (direction)
        {
            case 0:
                playerWeaponIndex--;
                break;
            case 1:
                playerWeaponIndex++;
                break;
            default:
                playerWeaponIndex++;
                break;
        }

        if (playerWeaponIndex < 0)
        {
            playerWeaponIndex = playerWeapons.Count - 1;
        }

        if (playerWeaponIndex >= playerWeapons.Count)
        {
            playerWeaponIndex = 0;
        }

        playerCurrentWeapon = playerWeapons[playerWeaponIndex];


        if (currentWeaponModel != null)
        {
            Destroy(currentWeaponModel);
            currentWeaponModel = Instantiate(playerWeapons[playerWeaponIndex].weaponModel, weaponModelSpawnPoint.position, weaponModelSpawnPoint.rotation, weaponModelSpawnPoint);
            currentWeaponModel.transform.localScale = Vector3.one;
        }

        weaponSwitchDelegate();
    }
}
