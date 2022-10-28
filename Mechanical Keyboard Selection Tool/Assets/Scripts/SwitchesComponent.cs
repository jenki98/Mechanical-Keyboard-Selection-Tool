﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public struct Switches
{
    public string name;
    public string description;
    public float price;
}

public class SwitchesComponent : MonoBehaviour
{

    public List<Switches> switches = new List<Switches>();

    public Switches holyPandas;

    private void Start()
    {
        holyPandas.name = "Holy Panda";
        holyPandas.description = "Tacile switches, Polycarbonate plate, Polycarbonate Top Housing, Nylon Bottom Housing, 67g Spring";
        holyPandas.price = 40f;

        switches.Add(holyPandas);
    }


}
