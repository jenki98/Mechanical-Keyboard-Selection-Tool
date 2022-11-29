using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModelUIController : MonoBehaviour
{
    private GameObject lastModel;
    [SerializeField] private Transform templateParent;
    // Start is called before the first frame update
    void Start()
    {
        EventManager.current.onModelUpdate += LoadKeyboardModel;

    }



    public void LoadKeyboardModel(int i)
    {
        Debug.Log("Load Model");
        KeyboardManager.Instance.SetCurrentModel(i);
        EventManager.current.ModelSelect(i);
        DestroyModel(lastModel);
        GameObject keyboardModel = Instantiate(Resources.Load(KeyboardManager.Instance.GetKeyboards()[i].modelName, typeof(GameObject)), templateParent) as GameObject;
        lastModel = keyboardModel;

    }

    private void DestroyModel(GameObject model)
    {
        if (lastModel != null)
        {
            Destroy(model);
        }

    }
}
