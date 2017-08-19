using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovemntFP : MonoBehaviour {
 
    public GameObject player;
    public float speed = 3;
    public float jumpPower = 5;
    public float turnRate = 3.0f;
    public float gravity = -9.70f;
    public bool canPressButtom = false;
    public GameObject spawn;
    public GameObject StateOfGame;
    float moveX;
    float moveY;
    public bool platformyOn = false;
    Vector3 move;
    CharacterController Controler;

	// Use this for initialization
	void Start () {
        player.transform.position = spawn.transform.position;
        Controler = player.GetComponent<CharacterController>();

	}
	
	// Update is called once per frame
	void Update () {
        //grawitacja//

        if(!Controler.isGrounded)
        {
            Controler.SimpleMove(new Vector3(0, gravity, 0));
        }
        // Ruch//
        moveX = Input.GetAxis("Horizontal");
        moveY = Input.GetAxis("Vertical");
        
        move = new Vector3(moveX*speed,0, moveY * speed);
       
        //skok i "zabezpieczenie" przed double jumpem
        if(Input.GetKeyDown(KeyCode.Space) && Controler.isGrounded)
        {
            move.y = jumpPower;
            
        }
        //Wlasciwy ruch
        move = transform.rotation * move;
        Controler.Move(move*Time.deltaTime);
        
        //rotracja
        transform.Rotate(new Vector3(0,Input.GetAxis("Horizontal")*turnRate, 0));
        //rotacja kamery
        GetComponentInChildren<Transform>().Rotate(new Vector3(0, Input.GetAxis("Horizontal") * turnRate, 0));
     

        //jezeli gracz jest w poblizu przycisku i nacisnie E aktywuja sie platformy//
        if (Input.GetKeyDown(KeyCode.E) && canPressButtom)
        {
            StateOfGame.GetComponent<StateofGameScript>().AktywacjaPlatform();
            platformyOn = true;
        }
     

    }


   //upadek z platformy powoduje powrot do startu bez restartu sceny
    public void Restart()
    {
        transform.position = spawn.transform.position;
    }
}
