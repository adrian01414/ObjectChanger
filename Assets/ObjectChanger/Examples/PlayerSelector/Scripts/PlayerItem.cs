using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerItem : Data
{
    [SerializeField] private GameObject playerPrefab = null;
    [SerializeField] private GameObject playerUIPrefab = null;
    [SerializeField] private Transform parentUI = null;
    
    private void Awake()
    {
        playerPrefab = Instantiate(playerPrefab);
        playerUIPrefab = Instantiate(playerUIPrefab, parentUI.transform);
    }

    public override void Show()
    {
        playerPrefab.SetActive(true);
        playerUIPrefab.SetActive(true);
    }

    public override void Hide()
    {
        playerPrefab.SetActive(false);
        playerUIPrefab.SetActive(false);
    }

    public override void Select()
    {
        // TODO
    }
}
