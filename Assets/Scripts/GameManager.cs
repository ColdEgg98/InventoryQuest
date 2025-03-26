using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public Player player;

    private void Awake()
    {
        if (instance == null)
            instance = this;
        else
            Destroy(gameObject);

        SetData();
    }

    private void SetData()
    {
        // �����ڷ� ������ �Է�
        player = new Player();

        player.inventory = new List<Item>(Resources.LoadAll<Item>($"Items/"));
    }
}
