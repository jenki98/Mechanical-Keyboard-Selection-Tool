using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public struct KeyboardSelection
{ 

    public Keycaps Keycaps { get; set; }
    public Switches Switches { get; set; }
    public ModelColour ModelColour { get; set; }

    public float basePrice;



    public KeyboardSelection(Keycaps keycaps, Switches switches, ModelColour modelColour, float basePrice)
    {
        this.Keycaps = keycaps;
        this.Switches = switches;
        this.ModelColour = modelColour;
        this.basePrice = basePrice;
    }
    


}

