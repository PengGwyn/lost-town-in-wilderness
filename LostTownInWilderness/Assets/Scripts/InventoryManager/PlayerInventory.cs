using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    [SerializeField] private int maxInventorySlots = 10;
    [SerializeField] private Transform slotsParent;
    private InventorySlot[] _inventorySlots;

    private void Start()
    {
        _inventorySlots = slotsParent.GetComponentsInChildren<InventorySlot>();
    }

    public void AddItem(Item item)
    {
        foreach (InventorySlot inventorySlot in _inventorySlots)
        {
            if (inventorySlot.AddItem(item))
            {
                // we successfully add the item
                return;
            }
        }
    }
}
