using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectManager : MonoBehaviour
{
    public static ProjectManager Instance { get; set; }
    private currentConfig current;
    void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            DontDestroyOnLoad(this.gameObject);
            Instance = this;
        }

    }

    private void Start()
    {
        EventManager.current.Initialise(current);
    }
}
    
