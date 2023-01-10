using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject UIMenu;

    // Start is called before the first frame update
    void Start()
    {
        UIMenu.SetActive(false);
    }

    public void MapButton()
    {
        Debug.Log("Afisare Harta!");
    }

    public void ExitButton()
    {
        Application.Quit();
    }
}
