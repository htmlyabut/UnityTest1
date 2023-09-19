using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class space_key : MonoBehaviour {



    // Use this for initialization
    void Start(){

    }
    
    // Update is called once per frame
    void Update(){
    if(Input.GetKeyDown(KeyCode.Space))
		{
		Debug.Log("Space Key");
		}
    }
}