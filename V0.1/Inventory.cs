using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    [Header("InventorySettings")]
    [SerializeField] [Min(1)] private int MaxInventoryLength;
    [SerializeField] List<InventoryItem> InventoryItems = new List<InventoryItem>();

    public void AddInventoryItem(InventoryItem item)
    {
        if(InventoryListHelper.AddThisToList(item, InventoryItems, MaxInventoryLength))
        {
            Debug.Log("Item Basariyla Eklendi: " + item + "\n InventoryLength: " + InventoryItems.Count);
        }
        else
        {
            Debug.Log("Item Eklenemedi: " + item + "\n InventoryLength: " + InventoryItems.Count);
        }
        
    }
}
