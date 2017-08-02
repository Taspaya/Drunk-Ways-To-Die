using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class JocsPerLliure : MonoBehaviour {


    public Text nPlayers;
    private string thiso;
    private int numero;
    public void onclic() {

        thiso = nPlayers.text.ToString();
        int.TryParse(thiso, out numero);
        // Debug.Log(numero);

     

       if(numero > 0 && numero < 11)
        {
            PlayerPrefs.SetInt("numberofplayers", numero);
            SceneManager.LoadScene("AllGamesScene");
        }
        

      //  Debug.Log("nPlayers: " + namber);


    }
}
