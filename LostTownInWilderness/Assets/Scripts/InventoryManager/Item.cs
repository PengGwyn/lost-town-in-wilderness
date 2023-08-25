using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (fileName = "New Item", menuName = "Custom/Item"),]
public class Item : ScriptableObject
{
    public enum ItemType
    {
        Armor,
        Weapon,
        Thing,
        Food
    }

    public ItemType itemType;
    public new string name;
    public bool isStackable;
}
