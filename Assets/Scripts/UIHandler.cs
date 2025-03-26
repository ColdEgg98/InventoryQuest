using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIHandler : MonoBehaviour
{
    [Header("Status")]
    public Button statusBtn;
    public Image statusScreen;
    public Button backBtn;

    [Header("Inventory")]
    public Button inventoryBtn;
    public GameObject inventoryScreen;
    public Button invenBackBtn;

    private void Start()
    {
        statusBtn.onClick.AddListener(OpenStatus);
        backBtn.onClick.AddListener(CloseStatus);

        inventoryBtn.onClick.AddListener(OpenInventory);
        invenBackBtn.onClick.AddListener(CloseInventory);
    }

    private void OpenStatus()
    {
        UIManager.instance.UpdateStat();
        statusScreen.gameObject.SetActive(true);
        statusBtn.gameObject.SetActive(false);
        inventoryBtn.gameObject.SetActive(false);
    }

    private void CloseStatus()
    {
        statusScreen.gameObject.SetActive(false);
        statusBtn.gameObject.SetActive(true);
        inventoryBtn.gameObject.SetActive(true);
    }
    private void OpenInventory()
    {
        UIManager.instance.UpdateInventory();
        inventoryScreen.gameObject.SetActive(true);
        inventoryBtn.gameObject.SetActive(false);
        statusBtn.gameObject.SetActive(false);
    }

    private void CloseInventory()
    {
        UIManager.instance.UpdateUI();
        inventoryScreen.gameObject.SetActive(false);
        inventoryBtn.gameObject.SetActive(true);
        statusBtn.gameObject.SetActive(true);
    }
}
