using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class AddingPlayers : MonoBehaviour {

    public static AddingPlayers addingPlayers;

    [SerializeField]
    public List<Borracho> borrachos = new List<Borracho>();            // Declarem La List, contenedora de borrachos

    //private Borracho borrachin = new Borracho();

    public GameObject choosePlayer;
    public GameObject iniciJoc;

    public SpriteRenderer Player;
    public Image BTNresult;
    public Image RResulTT;

    public GameObject warmText;
    public Text warmTextText;
    public GameObject ColorPickerCanvas;
    public Text PlayerName;

    // Use this for initialization

    private void Awake()
    {
        if (addingPlayers == null)
        {
            addingPlayers = this;
            DontDestroyOnLoad(gameObject);
            Debug.Log("vengo de antes");
        }else if (addingPlayers != this)
        {
            Debug.Log("no se lo que passa pero te pinta de que funciona");
            Destroy(gameObject);
        }

    }

    void Start () {

        if (PlayerPrefs.GetInt("Playing") == 1) // ======================= FIRST TIME ======================
        {
            ColorPickerCanvas.SetActive(false);
            iniciJoc.SetActive(false);
            choosePlayer.SetActive(true);
        }
        else if(PlayerPrefs.GetInt("Playing") == 3)  // ================== PLAYING ======================
        {
            choosePlayer.SetActive(false);
            iniciJoc.SetActive(true);
        }
    }
	
	// Update is called once per frame
	void Update () {
        BTNresult.color = RResulTT.color;
        //Player.color = BTNresult.color;
    }

    public void RealAddPlayer()
    {
        Borracho borrachin = new Borracho();
        borrachin.nombreBorracho = PlayerName.text.ToString();                  // guardamos el texto en la variable name


        if (borrachos.Count == 6)
        {
            warmText.SetActive(true);
        }

        if (borrachin.nombreBorracho != "" && borrachos.Count < 6)
        {
            borrachin.nombreBorracho = PlayerName.text.ToString();                  // guardamos el texto en la variable name
            borrachin.ColorBorracho = RResulTT.color;
            Player.color = BTNresult.color;
            borrachos.Add(borrachin);                                               // insertamos el name en la List
            Debug.Log("Afegit: " + PlayerName.text.ToString());                    // comprovamos que se ha añadido
            warmText.SetActive(false);
        }
    
       

    
    }

    public void BorrarBorrachos()
    {
        borrachos = new List<Borracho>();
        warmText.SetActive(false);
     
    }

    

    public void choseColorBTN()
    {
        ColorPickerCanvas.SetActive(true);     
    }

    public void chooseColor()
    {
       // RResulTT.color = result;

        ColorPickerCanvas.SetActive(false);

    }

    public void GOGOGOGOGOGOG()
    {

      
        if(borrachos.Count == 0)
        {
            warmText.SetActive(true);
            warmTextText.text = "Necessitas gente para jugar!!";
        }
        else if (borrachos.Count == 1) {
            PlayerPrefs.SetString("Player1", borrachos[0].nombreBorracho);
            PlayerPrefs.SetInt("nPlayers", borrachos.Count);
        }
        else if (borrachos.Count == 2)
        {
            PlayerPrefs.SetString("Player1", borrachos[0].nombreBorracho);
            PlayerPrefs.SetString("Player2", borrachos[1].nombreBorracho);
            PlayerPrefs.SetInt("nPlayers", borrachos.Count);
        }
        else if (borrachos.Count == 3)
        {
            PlayerPrefs.SetString("Player1", borrachos[0].nombreBorracho);
            PlayerPrefs.SetString("Player2", borrachos[1].nombreBorracho);
            PlayerPrefs.SetString("Player3", borrachos[2].nombreBorracho);
            PlayerPrefs.SetInt("nPlayers", borrachos.Count);
        }
        else if (borrachos.Count == 4)
        {
            PlayerPrefs.SetString("Player1", borrachos[0].nombreBorracho);
            PlayerPrefs.SetString("Player2", borrachos[1].nombreBorracho);
            PlayerPrefs.SetString("Player3", borrachos[2].nombreBorracho);
            PlayerPrefs.SetString("Player4", borrachos[3].nombreBorracho);
            PlayerPrefs.SetInt("nPlayers", borrachos.Count);
        }
        else if (borrachos.Count == 5)
        {
            PlayerPrefs.SetString("Player1", borrachos[0].nombreBorracho);
            PlayerPrefs.SetString("Player2", borrachos[1].nombreBorracho);
            PlayerPrefs.SetString("Player3", borrachos[2].nombreBorracho);
            PlayerPrefs.SetString("Player4", borrachos[3].nombreBorracho);
            PlayerPrefs.SetString("Player5", borrachos[4].nombreBorracho);
            PlayerPrefs.SetInt("nPlayers", borrachos.Count);
        }
        else if (borrachos.Count == 6)
        {
            PlayerPrefs.SetString("Player1", borrachos[0].nombreBorracho);
            PlayerPrefs.SetString("Player2", borrachos[1].nombreBorracho);
            PlayerPrefs.SetString("Player3", borrachos[2].nombreBorracho);
            PlayerPrefs.SetString("Player4", borrachos[3].nombreBorracho);
            PlayerPrefs.SetString("Player5", borrachos[4].nombreBorracho);
            PlayerPrefs.SetString("Player6", borrachos[5].nombreBorracho);
            PlayerPrefs.SetInt("nPlayers", borrachos.Count);
        }
        choosePlayer.SetActive(false);
        iniciJoc.SetActive(true);
    }


    

    public void goToMainScene() {

        SceneManager.LoadScene("MainScene");
    }
}
