
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

    private void OnEnable()
    {
        EventManager.current.onInitialise += Initialise;
    }
    void Initialise(currentConfig current)
    {
        PopulateDropdown(current.switchSelection);
        
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

    void PopulateDropdown(int index = 0)
    {
        switchNames.Clear();
        dropDown.ClearOptions();
        foreach (Switches switches in KeyboardManager.Instance.GetSwitches())
        {
            switchNames.Add(switches.name);
        }
        dropDown.AddOptions(switchNames);
        Debug.Log(index);
        dropDown.value = 0;
        UpdateSelection(0);
    }

    

}

public struct currentConfig{
    public int switchSelection;
    public int keycapSelection;
    public int colourSelection;
    public int modelSelection;
    public int cameraSelection;
    public int backgroundSelection;

}
