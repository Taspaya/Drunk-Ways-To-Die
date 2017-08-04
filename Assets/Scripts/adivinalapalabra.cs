using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class adivinalapalabra : MonoBehaviour {

    public static List<string> firstWord = new List<string>();
    //public static List<string> secondWord = new List<string>();
    public Text mainText;
    public Text puraiers;
    private int nPlayers, P1, P2;

    public GameObject canvasito;

    private float listSize;


    private float randNumFloat;
    private int randNumInt;
    // Use this for initialization
    void Start () {
         
        firstWord.Add("Dinosaurio");       firstWord.Add("Mejicano");
        firstWord.Add("Consolador");       firstWord.Add("Italiano");
        firstWord.Add("Borracho");         firstWord.Add("Nazi");
        firstWord.Add("Caca");             firstWord.Add("Regordete");
        firstWord.Add("Polla");            firstWord.Add("Gamer");
        firstWord.Add("Papito-Mamita");    firstWord.Add("Reggetonero");
        firstWord.Add("Aburjinga");        firstWord.Add("Drogadicto");
        firstWord.Add("Culo");             firstWord.Add("Superdotado");
        firstWord.Add("Cerveza");          firstWord.Add("Millenial");
        firstWord.Add("Ruso");             firstWord.Add("Samurai");
        firstWord.Add("Huevo");            firstWord.Add("Japonés"); 
        firstWord.Add("Teta");             firstWord.Add("Pichacorta"); 
        firstWord.Add("Ubre");             firstWord.Add("Gamer");
        firstWord.Add("Demonio");          firstWord.Add("Bibliotecari@");
        firstWord.Add("Angel");            
        firstWord.Add("Dios");
        firstWord.Add("Filosofo");
        firstWord.Add("Cani-Choni");
        firstWord.Add("TheRock");
        firstWord.Add("Will Smith");
        firstWord.Add("Arguiñano");
        firstWord.Add("Tortuga");
        firstWord.Add("Conejo");
        firstWord.Add("Obama");
        firstWord.Add("Trump");
        firstWord.Add("Rajoy");
        firstWord.Add("Tomate");
        firstWord.Add("Patata");
        firstWord.Add("Preservativo");
        firstWord.Add("Gandalf");
        firstWord.Add("Pizza con Piña");
        firstWord.Add("Pikachu");
        firstWord.Add("Cobra");


        //changeText();
        canvasito.SetActive(false);
        // PlayerPrefs.SetInt("numberofplayers", 5);
        int nPlayers;

        nPlayers = PlayerPrefs.GetInt("numberofplayers");

        P1 = Random.Range(1, nPlayers);
        P2 = Random.Range(1, nPlayers);

        if (P2 == P1)
        {
            P2 = ((P2 + 1) % nPlayers) + 1;
        }
        mainText.text = " ";
        puraiers.text = "Siguientes: j" + P1 + " v/s " + "j" + P2;
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private int generateRandomNumber()
    {

        listSize = firstWord.Count;
        randNumFloat = Random.Range(0, listSize);
        randNumInt = ( int )randNumFloat;

        return randNumInt;
    }

    public void changeText()
    {
        generateRandomNumber();
        mainText.text = firstWord[generateRandomNumber()];

        P1 = Random.Range(1, nPlayers);
        P2 = Random.Range(1, nPlayers);

        if (P2 == P1)
        {
            P2 = ((P2 + 1) % nPlayers + 1);
        }
        puraiers.text = "Siguientes: j" + P1 + " v/s " + "j" + P2;
    }

    public void backBTN() {

        SceneManager.LoadScene("AllGamesScene");
    }

    public void back()
    {
        canvasito.SetActive(false);
    }
    public void info() {

        canvasito.SetActive(true);
    }


}
