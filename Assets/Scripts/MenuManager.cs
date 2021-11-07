using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;


public class MenuManager : MonoBehaviour
{
    public string playerName;
    public Text enteredName;

    public void OnTheNameSet()
    {
        playerName = enteredName.text;
        MainManager.Instance.NameText = enteredName;
    }
}
