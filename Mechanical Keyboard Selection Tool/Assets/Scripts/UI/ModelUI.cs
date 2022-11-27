using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ModelUI : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private Dropdown dropDown;
    List<string> modelNames = new List<string>();
    
    void Start()
    {
        PopulateDropdown(); //subscribe to event
        dropDown.onValueChanged.AddListener((dropDownValue) => UpdateSelection(dropDownValue));
    }

    // Update is called once per frame
    void UpdateSelection(int i)
    {

        string txt = dropDown.options[i].text;

        foreach (Keyboard keyboard in KeyboardManager.Instance.GetKeyboards())
        {
            if (txt.Equals(keyboard.modelName))
            {
                EventManager.current.ModelUpdate(i);

            }
        }


    }

    void PopulateDropdown()
    {
        foreach (Keyboard keyboard in KeyboardManager.Instance.GetKeyboards())
        {
            modelNames.Add(keyboard.modelName);
        }
        dropDown.AddOptions(modelNames);
    }
}
