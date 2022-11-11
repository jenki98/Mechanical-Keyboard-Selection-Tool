using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchesUIController : MonoBehaviour
{
    private KeyboardSelection keyboardStruct;
    [SerializeField] private Material switchesMaterial;
    //change keycap colour
    //update keyboard selection

    public void ChangeSwitches(Switches switches)
    {
        //switchesMaterial.color = switches.color;
    }

    public void UpdateSwitchesSelection(Switches switches)
    {
        KeyboardManager.Instance.SelectedSwitch(switches);

    }
}

