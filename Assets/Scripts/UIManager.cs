using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [Header("BaseInfo")]
    public TextMeshProUGUI nameTxt;
    public TextMeshProUGUI levelTxt;
    public TextMeshProUGUI EXPTxt;
    public TextMeshProUGUI goldAmountTxt;
    public Slider slider;

    [Header("Status")]
    public TextMeshProUGUI attackTxt;
    public TextMeshProUGUI defenceTxt;
    public TextMeshProUGUI healthTxt;
    public TextMeshProUGUI critTxt;

    [Header("Inventory")]
    public TextMeshProUGUI invenAmountTxt;
    public GameObject invenInitPivot;

    public Player player;

    private void Start()
    {
        player = GameManager.instance.player;

        UpdateUI();
        UpdateStat();
        UpdateInventory();
    }

    private void UpdateUI()
    {
        nameTxt.text = player.stat.name;
        levelTxt.text = player.stat.level.ToString();
        EXPTxt.text = $"{player.stat.currentEXP}/{player.stat.maxEXP}";
        goldAmountTxt.text = player.stat.gold.ToString();
        slider.maxValue = player.stat.maxEXP;
        slider.value = player.stat.currentEXP;
    }

    private void UpdateStat()
    {
        attackTxt.text = player.stat.attack.ToString();
        defenceTxt.text = player.stat.defence.ToString();
        healthTxt.text = player.stat.health.ToString();
        critTxt.text = player.stat.crit.ToString();
    }

    private void UpdateInventory()
    {
        invenAmountTxt.text = player.inventory.Count.ToString();

        for (int i = 0; i < player.inventory.Count; i++)
        {
            GameObject item = new GameObject("Item");
            item.transform.SetParent(invenInitPivot.transform);
            item.AddComponent<Image>().sprite = player.inventory[i].icon;
        }
    }
}
