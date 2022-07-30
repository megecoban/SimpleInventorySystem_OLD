using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForTest : MonoBehaviour
{
    [SerializeField] private Inventory myInventory;

    // Start is called before the first frame update
    void Start()
    {
        InventoryItemTyper.itemType key = InventoryItemTyper.itemType.Key;
        InventoryItemTyper.itemType lSource = InventoryItemTyper.itemType.LightSource;
        InventoryItemTyper.itemType note = InventoryItemTyper.itemType.Note;
        InventoryItem item1 = new InventoryItem(1, "Item Key", key);
        InventoryItem item2 = new InventoryItem(2, "Item Light Source", lSource, 1, 80);
        InventoryItem item3 = new InventoryItem(3, "Item Note", note, 7);

        Debug.Log(item1);
        Debug.Log(item1.itemName);

        myInventory.AddInventoryItem(item1);
        myInventory.AddInventoryItem(item2);
        myInventory.AddInventoryItem(item3);
        myInventory.AddInventoryItem(item1);
        myInventory.AddInventoryItem(item2);
        myInventory.AddInventoryItem(item3);
        myInventory.AddInventoryItem(item1);

    }
}
