using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SwitchPanel : MonoBehaviour
{
    public GameObject LoginPanel;
    public GameObject RegisterPanel;
    public Button RegisterButton;
    public Button GototoLoginPanel;

    //Register button
    void Start()
    {
        RegisterButton.onClick.AddListener(() => {
            LoginPanel.SetActive(false);
            RegisterPanel.SetActive(true);
        });
        GototoLoginPanel.onClick.AddListener(() => {
            LoginPanel.SetActive(true);
            RegisterPanel.SetActive(false);
        });
    }
}