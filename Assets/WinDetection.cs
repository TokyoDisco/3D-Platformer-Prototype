using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinDetection : MonoBehaviour {
    public GameObject StateOfGame;
    public GameObject Canvas;
   
    private void OnTriggerEnter(Collider other)
    {
        
      // aktywacja canvasu i zmaian tekstu na gratulacje
        Canvas.SetActive(true);
        Canvas.GetComponentInChildren<Text>().text = "Gratulacje, za 5 sekund gra się zrestartuje";
        //wystartowanie licznika do zwyciestwa
        StateOfGame.GetComponent<StateofGameScript>().WinCountDownStart();
        //ograniczenie zeby gracz nie wypadl z plaformy bo dotarciu do ostatniej
        GameObject.Find("Gracz").GetComponent<PlayerMovemntFP>().speed = 1f;
    }

 
}
