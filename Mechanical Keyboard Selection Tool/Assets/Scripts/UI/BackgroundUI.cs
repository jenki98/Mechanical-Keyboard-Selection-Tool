using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class BackgroundUI : MonoBehaviour
{
    [SerializeField] private Dropdown dropDown;
    void Start()
    {
        dropDown.onValueChanged.AddListener((dropDownValue) => UpdateSelection(dropDownValue));

    }

    // Update is called once per frame
    void UpdateSelection(int i)
    {
        string txt = dropDown.options[i].text;
        EventManager.current.BackgroundUpdate(i);
        Debug.Log(txt);
    }
}
