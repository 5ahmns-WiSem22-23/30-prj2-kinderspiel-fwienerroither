using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EndScreenManager : MonoBehaviour
{

    public void PressRestart()
    {
        SceneManager.LoadScene("Start");
    }
}
