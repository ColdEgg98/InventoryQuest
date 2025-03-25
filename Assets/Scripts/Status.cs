using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Status
{
    string name;
    int level;
    int currentEXP;
    int maxEXP;

    int attack;
    int defence;
    int health;
    int crit;

    int gold;

    public Status ()
    {
        name = "Chad";
        level = 10;
        currentEXP = 0;
        maxEXP = 12;
        attack = 35;
        defence = 40;
        health = 100;
        crit = 25;
        gold = 20000;
    }
}
