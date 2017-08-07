using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Allgames : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void toPPTS()
    {
        SceneManager.LoadScene("PedraPaperTisores");
    }

    public void toAdivinas()
    {

        SceneManager.LoadScene("AdivinaLaPalabra");
    }
    public void toGlassJob()
    {

        SceneManager.LoadScene("glassjob");


    } 
    public void chargeRandomGame()
    {

        SceneManager.LoadScene(Random.Range(4,7));

    }
}
