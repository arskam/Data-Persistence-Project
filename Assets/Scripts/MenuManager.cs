using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;


public class MenuManager : MonoBehaviour
{
    public static MenuManager Instance;

    public string playerName;
    public InputField enteredName;

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    public void OnTheNameSet()
    {
        playerName = enteredName.text;
    }
}
