using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class StopCamera : MonoBehaviour
{
   [SerializeField] private GameObject cm;
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (EventSystem.current.IsPointerOverGameObject())
            {
                cm.SetActive(false);
            }
            else
            {
                cm.SetActive(true);
            }
        }
        
    }
}
