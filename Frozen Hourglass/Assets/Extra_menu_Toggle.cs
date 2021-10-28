using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Extra_menu_Toggle : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject extraMenu;
    private Toggle toggle;
    void Start()
    {
        toggle = GetComponent<Toggle>();
    }

    // Update is called once per frame
    void Update()
    {
        extraMenu.SetActive(toggle.isOn);
    }
}
