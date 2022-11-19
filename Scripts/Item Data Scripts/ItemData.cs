using UnityEngine;

public class ItemData : ScriptableObject
{
    [Header("Basic Item Info")]
    public string itemName = "new Item";
    public string itemDescription = "This is a brand new item.";
    public float itemWeightValue = 1.0f;
    public int itemMaxQuantity = 1;

    [Header("Basic Item UI")]
    public Sprite itemUISprite = null;
}
