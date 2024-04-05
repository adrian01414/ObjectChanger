using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelItem : Data
{
    [SerializeField] private GameObject levelPrefab = null;
    [SerializeField] private Transform parentUI = null;
    [SerializeField] private int levelId = 0;

    private void Awake() {
        levelPrefab = Instantiate(levelPrefab, parentUI);
    }

    public override void Hide()
    {
        levelPrefab.SetActive(false);
    }

    public override void Select()
    {
        SceneManager.LoadScene(levelId);
    }

    public override void Show()
    {
        levelPrefab.SetActive(true);
    }
}
