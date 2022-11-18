using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class EventManager : MonoBehaviour
{
    public static EventManager current;
    public event Action onPriceUpdate;
    public event Action onModelSelect;
    private void Awake()
    {
        current = this;
    }


    public void PriceUpdate()
    {
        onPriceUpdate?.Invoke();


    }


    public void ModelSelect()
    {
        onModelSelect?.Invoke();
    }


}
