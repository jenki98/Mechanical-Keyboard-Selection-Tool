using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraUI : MonoBehaviour
{

    [SerializeField] private Dropdown dropDown;
    void Start()
    {
        EventManager.current.onInitialise += Initialise;
        dropDown.onValueChanged.AddListener((dropDownValue) => UpdateSelection(dropDownValue));

    }
    private void OnEnable()
    {
       // EventManager.current.onInitialise += Initialise;
    }
    void Initialise(currentConfig current)
    {
        dropDown.value = 0;
        string txt = dropDown.options[0].text;
        EventManager.current.CameraUpdate(txt);
    }
     void UpdateSelection(int i)
    {
        string txt = dropDown.options[i].text;
        EventManager.current.CameraUpdate(txt);
        Debug.Log(txt);
    }
}
