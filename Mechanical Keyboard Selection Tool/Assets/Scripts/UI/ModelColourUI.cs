 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
[RequireComponent(typeof(ModelColourUIController))]
public class ModelColourUI : MonoBehaviour
{
    [SerializeField] private ModelColourUIController UIController;

    [SerializeField] private GameObject templatePrefab;
    [SerializeField] private Transform templateParent;

    
    // Update is called once per frame
    private void Start()
    {
        EventManager.current.onModelSelect += AddColours;

       // AddColours(); // observer
    }
   

    void AddColours()
    {
        foreach (ModelColour modelColour in KeyboardManager.Instance.GetModelColours())
        {
            
            GameObject newButton = Instantiate(templatePrefab, templateParent);
            Button btn = newButton.GetComponentInChildren<Button>();
            btn.onClick.AddListener(() => { UpdateSelection(newButton); });

            ChangeButtonColour(btn, modelColour);
           
        }
    }


    void ChangeButtonColour(Button btn, ModelColour modelColour )
    {
        var btnColor = btn.colors;
        Color colour = modelColour.colour;
        btnColor.normalColor = colour;
        colour.a = 0.5f;
        btnColor.highlightedColor = colour;
        btnColor.selectedColor = colour;
        btn.colors = btnColor;
    }
   void UpdateSelection(GameObject colourButton)
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
