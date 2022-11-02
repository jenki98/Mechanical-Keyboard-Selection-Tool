 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ModelColourUI : MonoBehaviour
{
    [SerializeField] private Keyboard keyboard;

    [SerializeField] private GameObject templatePrefab;
    [SerializeField] private Transform templateParent;

    // Update is called once per frame
    private void Start()
    {
       
        AddColours();
    }
    void Update()
    {

    }

    void AddColours()
    {
        foreach (var colour in keyboard.GetModelColours())
        {
           GameObject newTemp = Instantiate(templatePrefab, templateParent);
           Button btn = newTemp.GetComponentInChildren<Button>();
           var btnColor = btn.colors;
           btnColor.normalColor = colour.colour.normalColor;
           btn.colors = btnColor;
        }
    }
}
