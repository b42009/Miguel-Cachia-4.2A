using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class padal : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        
        float mousposinunits = (Input.mousePosition.x / Screen.width * 16 )- 8;
        Vector3 newpadalposition = new Vector3(mousposinunits, gameObject.transform.position.y, gameObject.transform.position.z);
        newpadalposition.x = Mathf.Clamp(mousposinunits,-7.35f,7.35f);
        gameObject.transform.position = newpadalposition;
		
	}
}
