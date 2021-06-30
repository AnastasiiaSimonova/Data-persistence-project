using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
using System.IO;


public class NameManager : MonoBehaviour
{
    public static NameManager Instance;
    public InputField usernameInput;
    public static string username;

    private void Awake()
    {
        // start of new code
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        // end of new code

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    void Start()
    {
        if (username != null)
            usernameInput.text = username;
    }

    public void SaveUsername(string newName)
    {
        username = newName;
    }
}
