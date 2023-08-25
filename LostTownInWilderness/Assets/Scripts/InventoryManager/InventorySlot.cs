using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventorySlot : MonoBehaviour
{
    // can contains 64 pieces of items in a stock
    [SerializeField] private int maxItem = 64;
    [SerializeField] private List<Item> _items = new List<Item>();
    [SerializeField] private bool _isFull = false;

    public bool AddItem(Item newItem)
    {
        if (_items.Count > 0)
        {
            string firstItemName = _items[0].name;
            if (firstItemName != newItem.name)
            {
                return false;   
            }   
        }

        if (_items.Count >= maxItem || _isFull)
            return false;

        if (!newItem.isStackable)
        {
            _isFull = true;
            Debug.Log("Inventory slot is full");
        }
        
        _items.Add(newItem);

        if (_items.Count >= maxItem)
            _isFull = true;
        return true;
    }
}
