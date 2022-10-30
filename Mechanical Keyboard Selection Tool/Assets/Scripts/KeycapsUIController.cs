using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class KeycapsUIController : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private List<Keycaps> keycaps = new List<Keycaps>();
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

        foreach(Keycaps keycap in keycaps)
        {
            if (txt.Equals(keycap.name))
            {
                description.text = keycap.description;
            }
        }
        
    }
}
