using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardManager : MonoBehaviour
{
    public static KeyboardManager Instance { get; set; }
    private KeyboardSelection keyboardSelection;
    [SerializeField] private Keyboard keyboard;

    private void Awake()
    {
       if(Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }
        PrintList();
    }

    public void PrintList()
    {
        foreach(Keycaps keycap in keyboard.keycaps)
        {
            Debug.Log(keycap.name);
        }
    }
    public List<Keycaps> GetKeycaps()
    {
        return keyboard.keycaps;
    }

    public List<Switches> GetSwitches()
    {
        return keyboard.switches;
    }

    public List<ModelColour> GetModelColours()
    {
        return keyboard.colours;
    }

    public float GetBasePrice()
    {
        keyboardSelection.basePrice = keyboard.basePrice;
        return keyboard.basePrice;
    }

    public void SelectedKeycap(Keycaps keycap)
    {
        keyboardSelection.Keycaps = keycap;
        Debug.Log(keycap.price);
    }

    public void SelectedSwitch(Switches switches)
    {
        keyboardSelection.Switches = switches;
    }

    public void SelectedColour(ModelColour modelColour)
    {
        keyboardSelection.ModelColour = modelColour;
    }

    public KeyboardSelection GetKeyboardSelection()
    {
        GetBasePrice();
        return keyboardSelection;
    }


}
