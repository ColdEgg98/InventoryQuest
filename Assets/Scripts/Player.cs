using System.Collections.Generic;
using static UnityEditor.Progress;

public class Status
{
    internal string name;
    internal int level;
    internal int currentEXP;
    internal int maxEXP;

    internal int attack;
    internal int defence;
    internal int health;
    internal int crit;

    internal int gold;

    public Status()
    {
        name = "Chad";
        level = 10;
        currentEXP = 9;
        maxEXP = 12;
        attack = 35;
        defence = 40;
        health = 100;
        crit = 25;
        gold = 20000;
    }
}

public class Player
{
    public Status stat = new Status();
    public List<Item> inventory;

    public void GetItem(Item newItem)
    {
        inventory.Add(newItem);
    }

    public void EquipItem(Item item)
    {
        item.isEquip = true;
        ApplyValue(item, true);
    }

    public void UnEquipItem(Item item)
    {
        item.isEquip = false;
        ApplyValue(item, false);
    }

    private void ApplyValue(Item item, bool isUP)
    {
        int negativeValue = (isUP) ? 1 : -1;

        if (item.isAttackUp)
            stat.attack += item.value * negativeValue;
        if (item.isDefenceUp)
            stat.defence += item.value * negativeValue;
        if (item.isHPUp)
            stat.health += item.value * negativeValue;
        if (item.isCritUp)
            stat.crit += item.value * negativeValue;
    }
}
