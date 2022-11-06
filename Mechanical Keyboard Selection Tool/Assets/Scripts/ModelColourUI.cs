 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ModelColourUI : MonoBehaviour
{
    [SerializeField] private Keyboard keyboard;
    private ModelColourUIController uIController;

    [SerializeField] private GameObject templatePrefab;
    [SerializeField] private Transform templateParent;

    
    // Update is called once per frame
    private void Start()
    {
        uIController = GetComponent<ModelColourUIController>();
        AddColours();
    }
   

    void AddColours()
    {
        foreach (var colour in keyboard.GetModelColours())
        {
            GameObject newButton = Instantiate(templatePrefab, templateParent);
            Button btn = newButton.GetComponentInChildren<Button>();
            btn.onClick.AddListener(() => { UpdateSelection(newButton); });
 
            var btnColor = btn.colors;
            Color c = colour.colour;
            btnColor.normalColor = c;
            c.a = 0.5f;
            btnColor.highlightedColor = c;
            btnColor.selectedColor = c;
            btn.colors = btnColor;
        }
    }

   public void UpdateSelection(GameObject colourButton)
    {
        foreach(ModelColour modelColour in keyboard.GetModelColours())
        {
            Button btn = colourButton.GetComponent<Button>();
            if(btn.colors.normalColor == modelColour.colour)
            {
                uIController.ChangeModelColour(modelColour);
                uIController.UpdateModelColourSelection(modelColour);
            }

        }

    }

}
