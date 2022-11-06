using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeycapsUIController : MonoBehaviour
{
    private KeyboardSelection keyboardStruct;
   [SerializeField]private Material keycapMaterial;
    //change keycap colour
    //update keyboard selection

    public void ChangeKeycap(Keycaps keycap)
    {
        keycapMaterial.color = keycap.color;
    }

    public void UpdateKeycapSelection(Keycaps keycap)
    {
        keyboardStruct.keycap = keycap;
    }
}
