using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class InventoryListHelper
{
    public static bool AddThisToList(InventoryItem item, List<InventoryItem> itemList, int maxItemLength)
    {
        bool returnVal = false;
        InventoryItem targetItem = null;

        for(int a=0; a<itemList.Count; a++)
        {
            if(itemList[a].itemID == item.itemID)
            {
                targetItem = itemList[a];
            }
        }

        if(targetItem != null)
        {
            targetItem.IncreaseAmount(item.itemAmount);
            returnVal = true;
        }
        else
        {
            if(maxItemLength>itemList.Count)
            {
                itemList.Add(item);
                returnVal = true;
            }
            else
            {
                returnVal = false;
            }
        }

        return returnVal;
    }
}
