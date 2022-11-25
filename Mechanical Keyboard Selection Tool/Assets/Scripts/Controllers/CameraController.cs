﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CameraController : MonoBehaviour
{
    [SerializeField] private GameObject freeCam;
    [SerializeField] private Transform keyboard;
    private string cameraView;


    private Vector3 startPos;
    private Vector3 endPos;

    private void Start()
    {
        EventManager.current.onCameraViewUpdate += UpdateCameraView;
        cameraView = "FreeView";
        
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (EventSystem.current.IsPointerOverGameObject())
            {
                freeCam.SetActive(false);
            }
            else
            {
                if (cameraView.Equals("FreeView"))
                {
                    freeCam.SetActive(true);
                }

            }
        }

    }

    void UpdateCameraView(string s)
    {
        cameraView = s;
        if (s.Equals("FreeView"))
        {
            Freeview();
        } else if (s.Equals("Top"))
        {
            TopView();
            
        } else if (s.Equals("Side"))
        {
            SideView();
        }
    }
    

    void Freeview()
    {
    
        freeCam.SetActive(true);
        
    }

    void TopView()
    {
       
        freeCam.SetActive(false);
        startPos = this.transform.position;
        endPos = new Vector3(-1.33f, 2.781f, 0.743f);
        StartCoroutine(MoveCam());


    }

    void SideView()
    {
        freeCam.SetActive(false);
        startPos = this.transform.position;
        endPos = new Vector3(-2.5f, 0.162f, 0.83f);
        StartCoroutine(MoveCam());

    }

    IEnumerator MoveCam()
    {
      
        float timeElapsed = 0f;
        float totalLerpTime = 1f;

        while(timeElapsed < totalLerpTime)
        {
            this.transform.position = Vector3.Lerp(startPos, endPos, (timeElapsed / totalLerpTime));
            this.transform.LookAt(keyboard);
            timeElapsed += Time.deltaTime;
            yield return new WaitForEndOfFrame();
        }

    }
}
