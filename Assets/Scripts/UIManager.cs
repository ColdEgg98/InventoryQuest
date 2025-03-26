using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public static UIManager instance;

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

    private void Awake()
    {
        if (instance == null)
            instance = this;
        else
            Destroy(gameObject);
    }

    private void Start()
    {
        player = GameManager.instance.player;

        UpdateUI();
        UpdateInventory();
    }

    public void UpdateUI()
    {
        nameTxt.text = player.stat.name;
        levelTxt.text = player.stat.level.ToString();
        EXPTxt.text = $"{player.stat.currentEXP}/{player.stat.maxEXP}";
        goldAmountTxt.text = player.stat.gold.ToString();
        slider.maxValue = player.stat.maxEXP;
        slider.value = player.stat.currentEXP;
    }

    public void UpdateStat()
    {
        attackTxt.text = player.stat.attack.ToString();
        defenceTxt.text = player.stat.defence.ToString();
        healthTxt.text = player.stat.health.ToString();
        critTxt.text = player.stat.crit.ToString();
    }

    public void UpdateInventory()
    {
        if(player.inventory.Count == 0)
        {
            invenAmountTxt.text = "0";
            Debug.Log("Inventory is Empty");
            return;
        }

        foreach (Transform child in invenInitPivot.transform)
        {
            Destroy(child.gameObject);
        }

        invenAmountTxt.text = player.inventory.Count.ToString();

        for (int i = 0; i < player.inventory.Count; i++)
        {
            GameObject item = new GameObject("Item");
            item.transform.SetParent(invenInitPivot.transform);
            item.AddComponent<Image>().sprite = player.inventory[i].icon;
            int currentindex = i;
            item.AddComponent<Button>().onClick.AddListener(() => EquipManage(currentindex));
        }
    }

    private void EquipManage(int index)
    {
        if (player.inventory[index].isEquip)
        {
            player.UnEquipItem(player.inventory[index]);
            Debug.Log($"UnEquipItem : {player.inventory[index].name}");
        }
        else
        {
            player.EquipItem(player.inventory[index]);
            Debug.Log($"EquipItem : {player.inventory[index].name}");
        }
    }
}
