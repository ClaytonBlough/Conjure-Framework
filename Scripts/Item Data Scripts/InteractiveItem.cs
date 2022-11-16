
using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "InteractiveItem")]
public abstract class InteractiveItem : ScriptableObject
{
    public ItemData myItemData = null;

    public enum ItemState { StartState, UpdateState, CompleteState }
    public ItemState itemState = ItemState.StartState;

    public abstract void StartItemAction();
    public abstract void DoItemAction();
    public abstract void CompleteItemAction();
}
