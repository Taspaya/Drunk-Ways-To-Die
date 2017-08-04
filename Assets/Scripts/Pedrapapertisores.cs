using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Pedrapapertisores : MonoBehaviour {

    public GameObject Pedra;
    public GameObject Paper;
    public GameObject Tisores;

    public GameObject infoBTN;
    public GameObject repensarBTN;
    public GameObject GoHomeBTN;

    // ======================================== dos players en un mbl ================================= // 

    public GameObject primerCanvas;
    public GameObject segonCanvas;

    private bool jugador1;
    private int p1, p2;
    public GameObject gameOverCanvas;
    public Text winText;
    
    // Use this for initialization
	void Start () {

        infoBTN.SetActive(false);
        primerCanvas.SetActive(true);
        segonCanvas.SetActive(false);
        gameOverCanvas.SetActive(false);
        jugador1 = true;
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void PedraBTN()
    {
        if (jugador1)
        {
            p1 = 3;
            Debug.Log("Player 1 ha triar pedra (3)");
            segonCanvas.SetActive(true);
        }
        else
        {
            p2 = 3;
            Debug.Log("Player 2 ha triar pedra (3)");
            gameOverCanvas.SetActive(true);
            result();
        }
        jugador1 = false;

       
        //Pedra.transform.position = new Vector2(540, 960);


    }
    public void PaperBTN()
    {
        if (jugador1)
        {
            p1 = 2;
            Debug.Log("Player 1 ha triar Paper (2)");
            segonCanvas.SetActive(true);

        }
        else
        {
            p2 = 2;
            Debug.Log("Player 2 ha triar Paper (2)");
            gameOverCanvas.SetActive(true);
            result();
        }
        jugador1 = false;
    }
    public void tisoresBTN()
    {
        if (jugador1)
        {
            p1 = 1;
            Debug.Log("Player 1 ha triar Tisores (1)");
            segonCanvas.SetActive(true);
        }
        else
        {
            p2 = 1;
            Debug.Log("Player 2 ha triar Tisores (1)");
            gameOverCanvas.SetActive(true);
            result();
        }

        jugador1 = false;
    }

    public void tornarJugar() {

        SceneManager.LoadScene("PedraPaperTisores");
        infoBTN.SetActive(false);
    }
    public void infoBUTN() {

        infoBTN.SetActive(true);

    }
    public void backBTN()
    {
        infoBTN.SetActive(false);
    }
    public void toAllGames() {
        
        SceneManager.LoadScene("AllGamesScene");
    }


    public void result()
    {
        gameOverCanvas.SetActive(true);

        if(p1 == 1 && p2 == 1)
        {
            winText.text = "EMPATE!";
            Debug.Log("EMPATE!");
        }
        else if(p1 == 1 && p2 == 2)
        {
            winText.text = "Ha ganado.. \n\nP1!!" ;
            Debug.Log("GANA P1");  //            P1
        }
        else if(p1 == 1 && p2 == 3)
        {
            winText.text = "Ha ganado.. \n\nP2!!";
            Debug.Log("GANA P2"); //            P2
        }
        else if (p1 == 2 && p2 == 1)
        {
            winText.text = "Ha ganado.. \n\nP2!!"; //        P2
            Debug.Log("GANA P2");
        }
        else if (p1 == 2 && p2 == 2)
        {
            winText.text = "EMPATE!";
            Debug.Log("EMPATE!");
        }
        else if (p1 == 2 && p2 == 3)
        {
            winText.text = "Ha ganado.. \n\nP1!!";//        P1
            Debug.Log("GANA P1");
        }
        else if (p1 == 3 && p2 == 1)
        {
            winText.text = "Ha ganado.. \n\nP1!!";//        P1      
            Debug.Log("GANA P1");
        }
        else if (p1 == 3 && p2 == 2)
        {
           winText.text = "Ha ganado.. \n\nP2!!";
            Debug.Log("GANA P2");//         P2
        }
        else if (p1 == 3 && p2 == 3)
        {
            winText.text = "EMPATE!";
            Debug.Log("EMPATE");
        }

    }

    public void gameP1()
    {
        primerCanvas.SetActive(false);
    }
    public void gameP2()
    {

        segonCanvas.SetActive(false);
    }
}
