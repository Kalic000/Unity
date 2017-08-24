using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen : MonoBehaviour {

     Animator anim;

	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        		
	}

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("entrato");
        if(Input.GetKeyDown(KeyCode.F))
        {
            Debug.Log("pushato");
            anim.SetBool("isDoorOpened", true);
        }
        if (Input.GetKeyUp(KeyCode.F))
        {
            anim.SetBool("isDoorOpened", false);
        }
    }
}
