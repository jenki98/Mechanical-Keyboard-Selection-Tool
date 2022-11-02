using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Keyboard", menuName = "Keyboards")]
public class Keyboard : ScriptableObject
{
    [SerializeField] private List<ModelColour> colours = new List<ModelColour>();
    [SerializeField] private List<Switches> switches = new List<Switches>();
    [SerializeField] private List<Keycaps> keycaps = new List<Keycaps>();

    [SerializeField] private float basePrice;


    public List<ModelColour> GetModelColours()
    {
        return colours;
    }

    public List<Switches> GetSwitches()
    {
        return switches;
    }

    public List<Keycaps> GetKeycaps()
    {
        return keycaps;
    }

    public float GetBasePrice()
    {
        return basePrice;
    }
  

   
}
