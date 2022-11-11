 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ModelColourUI : MonoBehaviour
{
    private ModelColourUIController UIController;

    [SerializeField] private GameObject templatePrefab;
    [SerializeField] private Transform templateParent;

    
    // Update is called once per frame
    private void Start()
    {
        UIController = GetComponent<ModelColourUIController>();
        AddColours();
    }
   

    void AddColours()
    {
        foreach (var colour in KeyboardManager.Instance.GetModelColours())
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
        foreach(ModelColour modelColour in KeyboardManager.Instance.GetModelColours())
        {
            Button btn = colourButton.GetComponent<Button>();
            if(btn.colors.normalColor == modelColour.colour)
            {
                UIController.ChangeModelColour(modelColour);
                UIController.UpdateModelColourSelection(modelColour);
            }

        }

    }

}
