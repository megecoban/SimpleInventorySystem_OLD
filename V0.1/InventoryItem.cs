using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace InventoryItemTyper
{
    public enum itemType
    {
        Key,
        Note,
        Collectible,
        LightSource,
        Battery,
        HealthItems,
        Map,
        MissionItems
    }
}

public class InventoryItem : IInventoryItem
{

    [Min(0)] private int ItemID;
    public int itemID { get { return ItemID; } }

    private string ItemName;
    public string itemName { get { return ItemName; } }

    private InventoryItemTyper.itemType ItemType;

    [Min(0)] private int ItemAmount;
    public int itemAmount { get { return ItemAmount; } }
    [Min(0)] private int ItemDurability;

    private bool isUseableItem = false;
    private bool isDurabilityChange = false;


    public InventoryItem(int id, string name, InventoryItemTyper.itemType type, int amount = 1, int durability = 100)
    {
        ItemID = id;
        ItemName = name;
        ItemType = type;
        ItemAmount = amount;
        ItemDurability = durability;
    }

    public void Use()
    {
        if(isUseableItem)
        {

        }
    }

    public void Examine()
    {
        throw new System.NotImplementedException();
    }

    public void DecreaseAmount(int decreaseVal = 1)
    {
        ItemAmount = ItemAmount - decreaseVal;
    }

    public void DecreaseDurability(int decreaseVal = 1)
    {
        if(isDurabilityChange)
        {
            ItemDurability = ItemDurability - decreaseVal;
        }
    }

    public void IncreaseAmount(int increaseVal = 1)
    {
        ItemAmount = ItemAmount + increaseVal;
    }

    public void IncreaseDurability(int increaseVal = 1)
    {
        if(isDurabilityChange)
        {
            ItemDurability = ItemDurability + increaseVal;
        }
    }
}
