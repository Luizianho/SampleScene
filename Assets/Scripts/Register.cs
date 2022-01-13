using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Register : MonoBehaviour
{
    public TMP_InputField UserNameInput;
    public TMP_InputField PasswordInput;
    public TMP_InputField RepeatPasswordInput;
    public TMP_InputField EmailInput;
    public Button RegisterButton;

    // Start is called before the first frame update
    void Start()
    {
        RegisterButton.onClick.AddListener(() => {
            if(UserNameInput.text != string.Empty && PasswordInput.text != string.Empty)
                if(PasswordInput.text == RepeatPasswordInput.text)
                    if(UserNameInput.text.Length >= 6 && PasswordInput.text.Length >= 6)
                        if(EmailInput.text != string.Empty)
                            if(EmailInput.text.IndexOf("@") > 0 && EmailInput.text.IndexOf('.') > 0 && 
                               EmailInput.text.Length >= 9 &&

                              (EmailInput.text.IndexOf("$") <= 0) &&      
                              (EmailInput.text.IndexOf("!") <= 0) &&   
                              (EmailInput.text.IndexOf("%") <= 0) &&     
                              (EmailInput.text.IndexOf("'") <= 0) &&     
                              (EmailInput.text.IndexOf("&") <= 0) &&   
                              (EmailInput.text.IndexOf("@.") <= 0) &&                                      
                              
                              (EmailInput.text.IndexOf(".pl") > 0 ||
                               EmailInput.text.IndexOf(".com") > 0 ||
                               EmailInput.text.IndexOf(".fr") > 0 ||
                               EmailInput.text.IndexOf(".net") > 0 ||
                               EmailInput.text.IndexOf(".br") > 0 ||
                               EmailInput.text.IndexOf(".in") > 0 ||
                               EmailInput.text.IndexOf(".de") > 0 ||
                               EmailInput.text.IndexOf(".ru") > 0 ||
                               EmailInput.text.IndexOf(".it") > 0 ||
                               EmailInput.text.IndexOf(".es") > 0 ||
                               EmailInput.text.IndexOf(".ca") > 0 ||
                               EmailInput.text.IndexOf(".nl") > 0 ||
                               EmailInput.text.IndexOf(".jp") > 0 ||
                               EmailInput.text.IndexOf(".sg") > 0 ||
                               EmailInput.text.IndexOf(".se") > 0 ||
                               EmailInput.text.IndexOf(".uk") > 0
                               ))
                                    {
                                        RegisterPanel();
                                    }
                                else
                                {
                                    Debug.Log("Insert correct email address!");
                                }
                            else
                            {
                                Debug.Log("Email is empty!");
                            }
                    else
                    {
                        Debug.Log("Login and password must have min. 6 numbers or letters");
                    }
                else
                {
                    Debug.Log("Incorrent password!");
                }
            else
            {
                Debug.Log("Text is empty!");
            }
        });
    }

    void RegisterPanel()
    {
        StartCoroutine(Main.Instance.Web.RegisterRequest(UserNameInput.text, PasswordInput.text, RepeatPasswordInput.text, EmailInput.text));
    }
}