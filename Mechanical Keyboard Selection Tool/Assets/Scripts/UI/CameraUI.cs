using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraUI : MonoBehaviour
{

    [SerializeField] private Dropdown dropDown;
    void Start()
    {
        dropDown.onValueChanged.AddListener((dropDownValue) => UpdateSelection(dropDownValue));

    }

     void UpdateSelection(int i)
    {
        string txt = dropDown.options[i].text;
        EventManager.current.CameraUpdate(txt);
        Debug.Log(txt);
    }
}
