using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class AddingPlayers : MonoBehaviour {

    public static AddingPlayers addingPlayers;

    [SerializeField]
    public List<Borracho> borrachos = new List<Borracho>();            // Declarem La List, contenedora de borrachos

    private Borracho borrachin = new Borracho();
    public Image imagen;
    private Color colorin;
    public Image imagensita;

    private int namesWriterCounter;
    public GameObject ColorPickerCanvas;
    public Text PlayersNames;
    public Text PlayerName;

    // Use this for initialization

  /*  private void Awake()
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

    }*/

    void Start () {
        ColorPickerCanvas.SetActive(false);
        borrachos.Add(borrachin);
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void RealAddPlayer()
    {
        Borracho borrachin = new Borracho();
        borrachin.nombreBorracho = PlayerName.text.ToString();                  // guardamos el texto en la variable name

        if (borrachin.nombreBorracho != "")
        {
            borrachin.nombreBorracho = PlayerName.text.ToString();                  // guardamos el texto en la variable name
            borrachin.ColorBorracho = imagensita.color;
            borrachos.Add(borrachin);                                               // insertamos el name en la List
            Debug.Log("Afegit: " + PlayerName.text.ToString());                                           // comprovamos que se ha añadido
            namesWriterCounter++;
        }
        namesWriter();

        PlayersNames.color = borrachos[namesWriterCounter].ColorBorracho;

       // borrachin.ColorBorracho = new Color(borrachin.Red, borrachin.Green, borrachin.Blue, 100);
    }

    public void BorrarBorrachos()
    {
        borrachos = new List<Borracho>();
        borrachos.Add(borrachin);
        namesWriterCounter = 0;
        PlayersNames.text = null;
        namesWriter();
    }

    public void namesWriter()
    {
        PlayersNames.text = PlayersNames.text.ToString() + "\n" + borrachos[namesWriterCounter].nombreBorracho;           // Añades el siguiente                

    }

    public void goGameScene() {
        

        SceneManager.LoadScene("TableroPrincipal");
    }
    public void choseColorBTN()
    {
        ColorPickerCanvas.SetActive(true);
    }

    public void chooseColor()
    {

        /* borrachin.Red = imagen.color.r;
         borrachin.Green = imagen.color.g;
         borrachin.Blue = imagen.color.b;*/

        borrachin.ColorBorracho = new Color(imagen.color.r, imagen.color.g, imagen.color.b, 100);
        ColorPickerCanvas.SetActive(false);

        imagensita.color = borrachin.ColorBorracho; 
    }

    public void goToMainScene() {

        SceneManager.LoadScene("MainScene");
    }
}
