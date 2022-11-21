using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CameraController : MonoBehaviour
{
   [SerializeField] private GameObject freeCam;
    private Vector3 startMarker;
    private Vector3 endMarker;
    private string cameraView;

    // Movement speed in units per second.
    public float speed = 1.0F;

    // Time when the movement started.
    private float startTime;

    // Total distance between the markers.
    private float journeyLength;
    private float distCovered;
    private void Start()
    {
      //  startTime = Time.time;
        EventManager.current.onCameraViewUpdate += UpdateCameraView;
        
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

      //  distCovered = (Time.time - startTime) * speed;

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
        //startMarker = this.transform.position;
        //endMarker = new Vector3();
        //journeyLength = Vector3.Distance(startMarker, endMarker);
        //float fractionOfJourney = distCovered / journeyLength;
        //transform.position = Vector3.Lerp(startMarker, endMarker, fractionOfJourney);
        freeCam.SetActive(false);
        this.transform.position = new Vector3(-0.994f, 2.5f, 0.817f);
        this.transform.eulerAngles = new Vector3(90f, 0f, 0f);

    }

    void SideView()
    {
        freeCam.SetActive(false);
        this.transform.position = new Vector3(-2.3f, 0.162f, 0.83f);
        this.transform.eulerAngles = new Vector3(0f, 90f, 0f);
    }
}
