using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [Header("BaseInfo")]
    private Player player;
    public TextMeshProUGUI nameTxt;
    public TextMeshProUGUI levelTxt;
    public TextMeshProUGUI EXPTxt;
    public TextMeshProUGUI goldAmountTxt;
    public Slider slider;

    private void Start()
    {
        UpdateUI();
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
}
