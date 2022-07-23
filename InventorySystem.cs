using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

[Serializable]
public class InventorySystem : MonoBehaviour
{
    public sSprayPaintOnWall sparyWall;
    Dictionary<InventoryItemData, InventoryItem> m_itemDictionary;
    
    

    public List<InventoryItem> inventory  = new List<InventoryItem>();
    public static InventorySystem current;

    private void Awake()
    {
        current = this;
        m_itemDictionary = new Dictionary<InventoryItemData, InventoryItem>();
    }

    public void Add(InventoryItemData refData)
    {
        InventoryItem newItem = new InventoryItem(refData);
        inventory.Add(newItem);
        m_itemDictionary.Add(refData, newItem);
    }

    public void ChangeSpray(Sprite image)
    {
        sparyWall.curSpray = image;
    }

}


[Serializable]

public class InventoryItem
{
    public InventoryItemData data; 
    public int stackSize;
    
    public InventoryItem(InventoryItemData source)
    {
        data = source;

    }
}
