using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Item", menuName = "Custom/Item", order = 1)]
public class Item : ScriptableObject
{
    public Sprite icon;
    public int value;
    public bool isEquip;
    public bool isAttackUp;
    public bool isDefenceUp;
    public bool isHPUp;
    public bool isCritUp;
}
