using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModelColourUIController : MonoBehaviour
{
    private KeyboardSelection keyboardStruct = new KeyboardSelection();
    [SerializeField] private Material boardMaterial;
    //change keycap colour
    //update keyboard selection

    public void ChangeModelColour(ModelColour modelColour)
    {
        boardMaterial.color = modelColour.colour;
    }

    public void UpdateModelColourSelection(ModelColour modelColour)
    {
        KeyboardManager.Instance.SelectedColour(modelColour);
    }
}
