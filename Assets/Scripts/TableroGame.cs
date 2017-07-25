using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TableroGame : MonoBehaviour {


    [SerializeField]
    public List<Borracho> borrachos;

    public Permanent Scriptpjs;
    // Use this for initialization
	void Start () {


        Scriptpjs = GetComponent<Permanent>();
        borrachos = Scriptpjs.Feels.borrachos;


    }
	
	// Update is called once per frame 
	void Update () {
		
	}


}
