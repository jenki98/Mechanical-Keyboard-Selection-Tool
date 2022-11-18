using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeycapsUIController : MonoBehaviour
{
   [SerializeField]private Material keycapMaterial;
    //change keycap colour
    //update keyboard selection

    public void ChangeKeycap(Keycaps keycap)
    {
        keycapMaterial.color = keycap.color;
    }

    public void UpdateKeycapSelection(Keycaps keycap)
    {

        KeyboardManager.Instance.SelectedKeycap(keycap);
        EventManager.current.PriceUpdate();

    }
}
