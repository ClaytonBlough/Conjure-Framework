using UnityEngine;

public class ItemData : ScriptableObject
{
    [Header("Basic Item Info")]
    public string itemName = "new Item";
    public string itemDescription = "This is a brand new item.";
    public Sprite itemSprite = null;
}
