using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardManager : MonoBehaviour
{
    public static KeyboardManager Instance { get; set; }
    //[SerializeField] private KeyboardSelection[] keyboardSelections;
     //private int currentSelection;
    private KeyboardSelection currentKeyboardSelection;
     private int currentModel;
    [SerializeField] private List<Keyboard> keyboards; //LIST
    [SerializeField] private Keyboard keyboard;
    GameObject lastModel;



    void Awake()
    {
       if(Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }
       // EventManager.current.onModelSelect += LoadKeyboardModel;
     
    }

 
    //public void LoadKeyboardModel(int i)
    //{
    //    DestroyModel(lastModel);
    //    currentModel = i;
    //    GameObject keyboardModel = Instantiate(Resources.Load(keyboards[currentModel].modelName, typeof(GameObject))) as GameObject;
    //    lastModel = keyboardModel;
        
    //}

    //private void DestroyModel(GameObject model)
    //{
    //    if (lastModel != null)
    //    {
    //        Destroy(model);
    //    }
        
    //}
   

    public List<Keyboard> GetKeyboards()
    {
        return keyboards;
    }

    public int GetCurrentModelSelection()
    {
        return currentModel;
    }
        
    public List<Keycaps> GetKeycaps()
    {
        return keyboards[currentModel].keycaps;
    }

    public List<Switches> GetSwitches()
    {
        return keyboards[currentModel].switches;
    }

    public List<ModelColour> GetModelColours()
    {
        return keyboards[currentModel].colours;
    }

    public float GetBasePrice()
    {
        currentKeyboardSelection.basePrice = keyboards[currentModel].basePrice;
        return keyboards[currentModel].basePrice;
    }

    public void SelectedKeycap(Keycaps keycap)
    {
        currentKeyboardSelection.Keycaps = keycap;
        Debug.Log(keycap.price);
    }

    public void SelectedSwitch(Switches switches)
    {
        currentKeyboardSelection.Switches = switches;
    }

    public void SelectedColour(ModelColour modelColour)
    {
        currentKeyboardSelection.ModelColour = modelColour;
    }

    public KeyboardSelection GetKeyboardSelection()
    {
        GetBasePrice();
        return currentKeyboardSelection;
    }


}
