using UnityEngine;
using UnityEngine.SceneManagement;

public class ReloadScene : MonoBehaviour
{
    public GameObject blau, gruen, rosa, gelb;

    void Update()
    {
        if (blau == null && gruen == null && rosa == null && gelb == null)
        {
            SceneManager.LoadScene("BootGewinnt");
        }
    }
}
