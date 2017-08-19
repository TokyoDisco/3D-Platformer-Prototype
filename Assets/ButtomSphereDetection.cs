using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtomSphereDetection : MonoBehaviour {
    public GameObject Player;
    
    public GameObject Canvas;

    //sprawdzenie z collidrem jest gracz 
    void OnTriggerEnter(Collider other)
    {
        if(other.name == "Gracz")
        {
            //aktywacja canvasu z tekstem i mozliwosci nacisniecia przycisku
            Canvas.SetActive(true);
            Player.GetComponent<PlayerMovemntFP>().canPressButtom = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        //deaktywacja powyzszych
        Canvas.SetActive(false);
        Player.GetComponent<PlayerMovemntFP>().canPressButtom = false;
    }


}
