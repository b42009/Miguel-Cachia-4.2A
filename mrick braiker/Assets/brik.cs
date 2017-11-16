using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class brik : MonoBehaviour {
    int timeshit;

	// Use this for initialization
	void Start () {
        timeshit = 0;
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void OnCollisionEnter2D(Collision2D collision)
    {
        timeshit++;
        print(gameObject.name + " : " + timeshit);
    }
}
