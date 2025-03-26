using System.Collections.Generic;

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
}
