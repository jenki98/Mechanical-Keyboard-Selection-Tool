using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class KeycapsUI : MonoBehaviour
{
    // Start is called before the first frame update
    private KeycapsUIController UIController;
    [SerializeField] private Dropdown dropDown;
    [SerializeField] private TextMeshProUGUI description;


    string txt;
    int dropDownValue;
    List<string> keycapNames = new List<string>();

    void Start()
    {
        UIController = GetComponent<KeycapsUIController>();
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

    void PopulateDropdown()
    {
        foreach (Keycaps keycaps in KeyboardManager.Instance.GetKeycaps())
        {
            keycapNames.Add(keycaps.name);
        }
        dropDown.AddOptions(keycapNames);
    }
}
