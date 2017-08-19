using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallDetection : MonoBehaviour {


    //wywolanie metody powodujacej powrot do startu
    void OnTriggerEnter(Collider other)
    {
        GameObject.Find("Gracz").GetComponent<PlayerMovemntFP>().Restart();
    }
}
