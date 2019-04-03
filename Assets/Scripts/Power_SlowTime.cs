using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;

public class Power_SlowTime : MonoBehaviour {

    PowerState powerState;

    // Use this for initialization
    void Start ()
    {
        powerState = GetComponent<PowerState>();
    }
	
	// Update is called once per frame
	void Update ()
    {
        if(powerState.currentPower != PowerState.Powers.SlowTime)
        {
            return;
        }

        if (Input.GetButton("UseLeft"))
        {
            Debug.Log("Imagine, you are bending time !");
        }
         
    }
}
