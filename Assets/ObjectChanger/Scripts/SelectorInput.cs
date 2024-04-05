using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Selector))]
public class SelectorInput : MonoBehaviour
{
    [SerializeField] private KeyCode leftKey = KeyCode.LeftArrow;
    [SerializeField] private KeyCode rightKey = KeyCode.RightArrow;
    [SerializeField] private KeyCode selectKey = KeyCode.RightShift;

    private Selector selector = null;

    private void Awake()
    {
        selector = GetComponent<Selector>();
    }

    private void Update() {
#if UNITY_STANDALONE
        PCInput();
#elif UNITY_EDITOR
        PCInput();
#endif
    }

    private void PCInput() {
        if(Input.GetKeyDown(leftKey)){
            selector.PreviousItem();
        } else if(Input.GetKeyDown(rightKey)){
            selector.NextItem();
        } else if(Input.GetKeyDown(selectKey)){
            selector.SelectItem();
        }
    }
}
