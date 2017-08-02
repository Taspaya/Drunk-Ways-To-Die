using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pedrapapertisores : MonoBehaviour {

    public GameObject Pedra;
    public GameObject Paper;
    public GameObject Tisores;

    public GameObject infoBTN;
    public GameObject repensarBTN;
    public GameObject GoHomeBTN;
	// Use this for initialization
	void Start () {
        infoBTN.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void PedraBTN()
    {
        Paper.SetActive(false);
        Tisores.SetActive(false);

        Pedra.transform.position = new Vector2(540, 960);

        repensarBTN.SetActive(true);
        GoHomeBTN.SetActive(true);
    }

    public void PaperBTN()
    {
        Pedra.SetActive(false);
        Tisores.SetActive(false);

        Paper.transform.position = new Vector2(540, 960);

          repensarBTN.SetActive(true);
         GoHomeBTN.SetActive(true);
    }
    public void tisoresBTN()
    {
        Paper.SetActive(false);
        Pedra.SetActive(false);

        Tisores.transform.position = new Vector2(540, 960);

          repensarBTN.SetActive(true);
         GoHomeBTN.SetActive(true);
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
}
