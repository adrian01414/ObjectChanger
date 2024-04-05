using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Selector : MonoBehaviour
{
    [SerializeField] private List<Data> items = null;

    private int itemIndex = 0;

    private void Awake()
    {
        if (items.Count > 0)
        {
            foreach (var item in items)
            {
                item.Hide();
            }
            items[itemIndex].Show();
        }
    }

    [ContextMenu("NextItem")]
    public void NextItem()
    {
        items[itemIndex].Hide();
        if ((itemIndex + 1) == items.Count)
            itemIndex = 0;
        else
            itemIndex++;
        items[itemIndex].Show();
    }

    [ContextMenu("PreviousItem")]
    public void PreviousItem()
    {
        items[itemIndex].Hide();
        if (itemIndex == 0)
            itemIndex = items.Count - 1;
        else
            itemIndex--;
        items[itemIndex].Show();
    }

    [ContextMenu("SelectItem")]
    public void SelectItem()
    {
        items[itemIndex].Select();
    }
}
