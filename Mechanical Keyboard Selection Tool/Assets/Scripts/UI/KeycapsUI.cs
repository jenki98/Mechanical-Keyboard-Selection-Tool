using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class KeycapsUI : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private KeycapsUIController UIController;
    [SerializeField] private Dropdown dropDown;
    [SerializeField] private TextMeshProUGUI description;


    string txt;
    List<string> keycapNames = new List<string>();

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
        PopulateDropdown(current.keycapSelection);
    }

    void UpdateSelection(int i)
    {
        txt = dropDown.options[i].text;

        foreach (Keycaps keycaps in KeyboardManager.Instance.GetKeycaps())
        {
            if (txt.Equals(keycaps.name))
            {
                description.text = keycaps.description;
                UIController.UpdateKeycapSelection(keycaps);
                UIController.ChangeKeycap(keycaps);
            }
        }
    }

    void PopulateDropdown(int index = 0)
    {
        keycapNames.Clear();
        dropDown.ClearOptions();
        foreach (Keycaps keycaps in KeyboardManager.Instance.GetKeycaps())
        {
            keycapNames.Add(keycaps.name);
        }
        dropDown.AddOptions(keycapNames);
        dropDown.value = 0;
        UpdateSelection(0);

    }
}