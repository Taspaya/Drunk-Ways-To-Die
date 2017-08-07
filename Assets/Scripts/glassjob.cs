using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class glassjob : MonoBehaviour {



    public GameObject canvasito;
    public Text mainText;
    private int P1, P2, nPlayers;

    private void Start()
    {
        canvasito.SetActive(false);
        changeText();
    }
    public void closeCanvas()
    {
        canvasito.SetActive(false);
    }

    public void openCanvas()
    {
        canvasito.SetActive(true);

    }

    public void changeText()
    {

        int nPlayers;

        nPlayers = PlayerPrefs.GetInt("numberofplayers");

        P1 = Random.Range(1, nPlayers);
        P2 = Random.Range(1, nPlayers);

        if (P2 == P1)
        {
            P2 = ((P2 + 1) % nPlayers) + 1;
        }
        mainText.text = "j" + P1 + " v/s " + "j" + P2;
    }

    public void toallgames()
    {

        SceneManager.LoadScene("AllGamesScene");


    }
}
