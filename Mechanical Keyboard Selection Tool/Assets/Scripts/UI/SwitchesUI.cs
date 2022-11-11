
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SwitchesUI : MonoBehaviour
{
    [SerializeField] private Dropdown dropDown;
    [SerializeField] private TextMeshProUGUI description;

    List<string> switchNames = new List<string>();

    private SwitchesUIController UIController;

    string txt;
    int dropDownValue;

    void Start()
    {
        UIController = GetComponent<SwitchesUIController>();
        description = GetComponentInChildren<TextMeshProUGUI>();
        dropDown = GetComponentInChildren<Dropdown>();
        dropDown.ClearOptions();
        PopulateDropdown();

      
    }

    // Update is called once per frame
    void Update()
    {
        UpdateSelection();

    }

    void UpdateSelection()
    {
        dropDownValue = dropDown.value;
        txt = dropDown.options[dropDownValue].text;

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
        foreach (Switches switches in KeyboardManager.Instance.GetSwitches())
        {
            switchNames.Add(switches.name);
        }
        dropDown.AddOptions(switchNames);
    }
}
