using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RandomNumberGenerator2 : MonoBehaviour
{
    public GameObject blau;
    public GameObject gruen;
    public GameObject gelb;
    public GameObject rosa;
    public GameObject boot;
    public GameObject drawnColor;
    public SpriteRenderer drawedColorSprite;

    public int fortschrittBlau;
    public int fortschrittGelb;
    public int fortschrittGruen;
    public int fortschrittRosa;
    public int fortschrittBoot;
    public int zielFortschritt;
    public int fischeImZiel;

    public GameObject[] gameObjects;


    private int prevRandomNum;


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            int randomNumber = Random.Range(1, 7);
            prevRandomNum = randomNumber;
            if (randomNumber == 1)
            {
                if (blau != null && fortschrittBlau < zielFortschritt)
                {
                    blau.transform.position += new Vector3(1, 0, 0);
                    fortschrittBlau++;
                    drawedColorSprite.color = Color.blue;
                }
                else
                {
                    drawedColorSprite.color = Color.blue;
                }
            }
            else if (randomNumber == 2)
            {
                if (gruen != null && fortschrittGruen < zielFortschritt)
                {
                    gruen.transform.position += new Vector3(1, 0, 0);
                    fortschrittGruen++;
                    drawedColorSprite.color = Color.green;
                }
                else
                {
                    drawedColorSprite.color = Color.green;
                }
            }
            else if (randomNumber == 3)
            {
                if (gelb != null && fortschrittGelb < zielFortschritt)
                {
                    gelb.transform.position += new Vector3(1, 0, 0);
                    fortschrittGelb++;
                    drawedColorSprite.color = Color.yellow;
                }
                else
                {
                    drawedColorSprite.color = Color.yellow;
                }
            }
            else if (randomNumber == 4)
            {
                if (rosa != null && fortschrittRosa < zielFortschritt)
                {
                    rosa.transform.position += new Vector3(1, 0, 0);
                    fortschrittRosa++;
                    drawedColorSprite.color = Color.magenta;
                }
                else
                {
                    drawedColorSprite.color = Color.magenta;
                }
            }
            else if (randomNumber == 5 || randomNumber == 6)
            {
                boot.transform.position += new Vector3(1, 0, 0);
                fortschrittBoot++;
            }
        }

        if ((fortschrittBlau >= zielFortschritt && fortschrittRosa >= zielFortschritt) || (fortschrittBlau >= zielFortschritt && fortschrittGruen >= zielFortschritt) || (fortschrittBlau >= zielFortschritt && fortschrittGelb >= zielFortschritt) || (fortschrittRosa >= zielFortschritt && fortschrittGruen >= zielFortschritt) || (fortschrittRosa >= zielFortschritt && fortschrittGelb >= zielFortschritt) || (fortschrittGruen >= zielFortschritt && fortschrittGelb >= zielFortschritt))
        {
            Debug.Log("Fische im Meer!");
            SceneManager.LoadScene("FischGewinnt");
        }

        if (blau == null && gruen == null && rosa == null && gelb == null || fortschrittBoot >= zielFortschritt + 4)
        {
            SceneManager.LoadScene("BootGewinnt");
        }       
    }
}