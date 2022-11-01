
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SwitchesUI : MonoBehaviour
{


    TextMeshProUGUI descriptionTxt;
    [SerializeField] private List<Switches> switchList = new List<Switches>();
    [SerializeField] private Dropdown dropDown;
    [SerializeField] private TextMeshProUGUI description;

    List<string> switchNames = new List<string>();


    string txt;
    int dropDownValue;

    void Start()
    {
        description = GetComponentInChildren<TextMeshProUGUI>();
        dropDown = GetComponentInChildren<Dropdown>();
        dropDown.ClearOptions();
        PopulateDropdown();

      
    }

    // Update is called once per frame
    void Update()
    {
        UpdateDescription();

    }

    void UpdateDescription()
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

    void PopulateDropdown()
    {
        foreach (Switches switches in switchList)
        {
            switchNames.Add(switches.name);
        }
        dropDown.AddOptions(switchNames);
    }
}
