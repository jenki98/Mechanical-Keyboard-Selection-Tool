using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Keyboard", menuName = "Keyboards")]
public class Keyboard : ScriptableObject
{
    [SerializeField] public List<ModelColour> colours = new List<ModelColour>();
    [SerializeField] public List<Switches> switches = new List<Switches>();
    [SerializeField] public List<Keycaps> keycaps = new List<Keycaps>();

    [SerializeField] public float basePrice;







}
