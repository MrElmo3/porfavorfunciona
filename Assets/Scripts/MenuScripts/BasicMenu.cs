using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicMenu : MonoBehaviour
{
    
    public GameObject Menu;

    private void Awake()
    {
        Menu.SetActive(false);
    }
}
