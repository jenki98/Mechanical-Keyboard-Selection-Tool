
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SwitchesUI : MonoBehaviour
{
    [SerializeField] private Dropdown dropDown;
    [SerializeField] private TextMeshProUGUI description;

    List<string> switchNames = new List<string>();

    [SerializeField] private SwitchesUIController UIController;

    string txt;

    void Start()
    {
        EventManager.current.onModelSelect += PopulateDropdown;
        dropDown.onValueChanged.AddListener((dropDownValue) => UpdateSelection(dropDownValue));



    }

    void UpdateSelection(int i)
    {

        txt = dropDown.options[i].text;

        foreach (Switches switches in KeyboardManager.Instance.GetSwitches())
        {
            if (txt.Equals(switches.name))
            {
                UIController.UpdateSwitchesSelection(switches);
                description.text = switches.description;

            }
        }
    }

    void PopulateDropdown()
    {
        switchNames.Clear();
        dropDown.ClearOptions();
        foreach (Switches switches in KeyboardManager.Instance.GetSwitches())
        {
            switchNames.Add(switches.name);
        }
        dropDown.AddOptions(switchNames);
    }
}
