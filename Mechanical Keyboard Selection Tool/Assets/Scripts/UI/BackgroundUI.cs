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
        dropDown.value = 0;
        EventManager.current.BackgroundUpdate(0);

        dropDown.onValueChanged.AddListener((dropDownValue) => UpdateSelection(dropDownValue));

    }

    void Initialise(currentConfig current)
    {
        Debug.Log("hi");
        dropDown.value = 0;
        EventManager.current.BackgroundUpdate(0);
    }
    // Update is called once per frame
    void UpdateSelection(int i)
    {
        EventManager.current.BackgroundUpdate(i);
    }

    
}
