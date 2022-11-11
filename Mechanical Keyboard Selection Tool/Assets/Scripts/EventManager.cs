using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class EventManager : MonoBehaviour
{
    public delegate void SelectionAction();
    public static event SelectionAction OnSelectedEvent;

    public void OnSelect(BaseEventData eventData)
    {
        if(OnSelectedEvent != null)
        {
            OnSelectedEvent();
        }
    }

}
