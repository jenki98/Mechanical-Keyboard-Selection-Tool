using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class EventManager : MonoBehaviour
{
    public static EventManager current;

    private void Awake()
    {
        current = this;
    }

    public event Action onSelectionUpdate;
    public void SelectionUpdate()
    {
        if(onSelectionUpdate != null)
        {
            onSelectionUpdate();
             
        }
    }


}
