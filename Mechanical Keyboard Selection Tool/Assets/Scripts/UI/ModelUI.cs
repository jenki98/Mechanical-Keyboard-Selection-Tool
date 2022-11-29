using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ModelUI : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private Dropdown dropDown;
    List<string> modelNames = new List<string>();
    currentConfig current;
    private ModelUIController mController;

    
    void Start()
    {
        mController = GetComponent<ModelUIController>();
        PopulateDropdown();
        dropDown.onValueChanged.AddListener((dropDownValue) => UpdateSelection(dropDownValue));
    }
    //void Initialise(currentConfig current)
    //{
    //    Debug.Log("hi");
    //    PopulateDropdown(current.modelSelection);
    //}

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
        Debug.Log("populate");
        foreach (Keyboard keyboard in KeyboardManager.Instance.GetKeyboards())
        {
            modelNames.Add(keyboard.modelName);
        }
        dropDown.AddOptions(modelNames);
        dropDown.value = 0;
        mController.LoadKeyboardModel(0);
        //EventManager.current.ModelUpdate(0);
    }
   
}
