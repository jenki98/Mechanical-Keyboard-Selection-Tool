
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SwitchUIController : MonoBehaviour
{


    TextMeshProUGUI descriptionTxt;
    [SerializeField] private List<Switches> switchList = new List<Switches>();
    [SerializeField] private Dropdown dropDown;
    [SerializeField] private TextMeshProUGUI description;

    string txt;
    int dropDownValue;

    void Start()
    {
        description = GetComponentInChildren<TextMeshProUGUI>();
        dropDown = GetComponentInChildren<Dropdown>();
    }

    // Update is called once per frame
    void Update()
    {
        dropDownValue = dropDown.value;
        txt = dropDown.options[dropDownValue].text;

        foreach (Switches switches in switchList)
        {
            if (txt.Equals(switches.name))
            {
                description.text = switches.description;
            }
        }

    }
}
