using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StateofGameScript : MonoBehaviour {

    public bool isSwitchOn = false;
    public bool win = false;
    public GameObject ukryteplatformy;



	// Use this for initialization
	void Start () {
        //ukrycie platform//
        ukryteplatformy.SetActive(false);
		
	}
	
	// Update is called once per frame
	void Update () {
        //sprawdzenie czy gracz uruchomil przycisk//
		if(isSwitchOn)
        {
            ukryteplatformy.SetActive(true);
        }
        

        if(win)
        {
            //restart sceny
            SceneManager.LoadSceneAsync("demo");
        }
	}

    //aktywacja platfrom
    public void AktywacjaPlatform()
    {
        isSwitchOn = true;
    }

    

    public void WinCountDownStart()
    {
        //wystartowanie odliczania do zwyciestwa
        StartCoroutine(WinCountdown());
    }

    IEnumerator WinCountdown()
    {
        //odliczanie
        yield return new WaitForSeconds(5f);
        win = true;
    }
}
