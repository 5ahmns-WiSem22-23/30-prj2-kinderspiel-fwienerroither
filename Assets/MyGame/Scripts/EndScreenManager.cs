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