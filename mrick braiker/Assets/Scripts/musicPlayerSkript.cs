﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class musicPlayerSkript : MonoBehaviour {
    static musicPlayerSkript instint = null;

	// Use this for initialization
	void Start () {
        if(instint == null)
        {
            DontDestroyOnLoad(gameObject);
            instint = this;

        }
        else
        {
            Destroy(gameObject);
        }
        
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
