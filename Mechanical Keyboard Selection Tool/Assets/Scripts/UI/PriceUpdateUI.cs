using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PriceUpdateUI : MonoBehaviour
{

    
    private KeyboardSelection keyboard;
    [SerializeField] private TextMeshProUGUI priceTxt;
    private float price;

    void Start()
    {
        priceTxt = GetComponent<TextMeshProUGUI>();
        EventManager.current.onSelectionUpdate += GetUpdatedPrice;
    }

    
    private void GetUpdatedPrice()
    {
        keyboard = KeyboardManager.Instance.GetKeyboardSelection();
        price = keyboard.basePrice + keyboard.Keycaps.price + keyboard.Switches.price + keyboard.ModelColour.price;
        priceTxt.text = "Price: £" + price;
    }

   
}
