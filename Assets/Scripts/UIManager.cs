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

    private Player player;

    private void Start()
    {
        UpdateUI();
        UpdateStat();
    }

    private void UpdateUI()
    {
        player = GameManager.instance.player;

        nameTxt.text = player.stat.name;
        levelTxt.text = player.stat.level.ToString();
        EXPTxt.text = $"{player.stat.currentEXP}/{player.stat.maxEXP}";
        goldAmountTxt.text = player.stat.gold.ToString();
        slider.maxValue = player.stat.maxEXP;
        slider.value = player.stat.currentEXP;
    }
    private void UpdateStat()
    {
        player = GameManager.instance.player;

        attackTxt.text = player.stat.attack.ToString();
        defenceTxt.text = player.stat.defence.ToString();
        healthTxt.text = player.stat.health.ToString();
        critTxt.text = player.stat.crit.ToString();
    }
}
