using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class KeycapsUI : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private List<Keycaps> keycaps = new List<Keycaps>();
    [SerializeField] private Dropdown dropDown;
    [SerializeField] private TextMeshProUGUI description;

    string txt;
    int dropDownValue;
    List<string> keycapNames = new List<string>();

    void Start()
    {
        description = GetComponentInChildren<TextMeshProUGUI>();
        dropDown = GetComponentInChildren<Dropdown>();

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

        foreach (Keycaps keycap in keycaps)
        {
            if (txt.Equals(keycap.name))
            {
                description.text = keycap.description;
            }
        }
    }

    void PopulateDropdown()
    {
        foreach (Keycaps keycap in keycaps)
        {
            keycapNames.Add(keycap.name);
            Debug.Log(keycap.name);
        }
        dropDown.AddOptions(keycapNames);
    }
}
