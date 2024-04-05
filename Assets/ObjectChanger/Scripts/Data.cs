using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Data : MonoBehaviour, IShowable, ISelectable
{
    public abstract void Hide();

    public abstract void Show();

    public abstract void Select();
}
