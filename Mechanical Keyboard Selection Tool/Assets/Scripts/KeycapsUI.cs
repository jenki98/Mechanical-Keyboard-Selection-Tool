using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class KeycapsUI : MonoBehaviour
{
    // Start is called before the first frame update
    private KeycapsUIController uIController;
    [SerializeField] private Keyboard keyboard;
    [SerializeField] private Dropdown dropDown;
    [SerializeField] private TextMeshProUGUI description;


    string txt;
    int dropDownValue;
    List<string> keycapNames = new List<string>();

    void Start()
    {
        uIController = GetComponent<KeycapsUIController>();
        description = GetComponentInChildren<TextMeshProUGUI>();
        dropDown = GetComponentInChildren<Dropdown>();

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

        foreach (Keycaps keycaps in keyboard.GetKeycaps())
        {
            if (txt.Equals(keycaps.name))
            {
                description.text = keycaps.description;
                uIController.UpdateKeycapSelection(keycaps);
                uIController.ChangeKeycap(keycaps);
            }
        }

        
    }

    void PopulateDropdown()
    {
        foreach (Keycaps keycaps in keyboard.GetKeycaps())
        {
            keycapNames.Add(keycaps.name);
            Debug.Log(keycaps.name);
        }
        dropDown.AddOptions(keycapNames);
    }
}
