using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class EventManager : MonoBehaviour
{
    public static EventManager current;

    public event Action onPriceUpdate;
    public event Action<int> onModelSelect;
    public event Action<currentConfig> onInitialise;
    public event Action<int> onModelUpdate;
    public event Action<string> onCameraViewUpdate;
    public event Action<int> onBackgroundUpdate;
    private void Awake()
    {
        current = this;
    }
    public void PriceUpdate()
    {
        onPriceUpdate?.Invoke();
    }

    public void ModelSelect(int i)
    {
        onModelSelect?.Invoke(i);
    }

    public void ModelUpdate(int i)
    {
        onModelUpdate?.Invoke(i);
    }

    public void CameraUpdate(string s)
    {
        onCameraViewUpdate?.Invoke(s);
    }

    public void BackgroundUpdate(int i)
    {
        onBackgroundUpdate?.Invoke(i);
    }

    public void Initialise(currentConfig c)
    {
        onInitialise?.Invoke(c);
    }
}
