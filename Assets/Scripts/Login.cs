using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Login : MonoBehaviour
{
    public TMP_InputField UserNameInput;
    public TMP_InputField PasswordInput;
    public Button LoginButton;

    // Start is called before the first frame update
    void Start()
    {
        LoginButton.onClick.AddListener(() => {
            if(UserNameInput.text != string.Empty && PasswordInput.text != string.Empty)
                if(UserNameInput.text.IndexOf("'") == -1 &&
                    UserNameInput.text.IndexOf("?") == -1 &&
                    UserNameInput.text.IndexOf("=") == -1 &&
                    PasswordInput.text.IndexOf("?") == -1 &&
                    PasswordInput.text.IndexOf("=") == -1 && 
                    PasswordInput.text.IndexOf("'") == -1)
                    {
                        StartCoroutine(Main.Instance.Web.LoginRequest(UserNameInput.text, PasswordInput.text));
                    }
                    else
                    {
                        Debug.Log("Invalid text format!");
                    }
            else
            {
                Debug.Log("Text is empty!");
            }
        });
    }

}
