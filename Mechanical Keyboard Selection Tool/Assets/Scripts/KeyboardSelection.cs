using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public struct KeyboardSelection
{
    public Keycaps keycap;
    public Switches switches;
    public ModelColour modelColour;
    private float price;

    public float UpdatePrice()
    {
        price = keycap.price + switches.price + modelColour.price;
        return price;
    }
}

