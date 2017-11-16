using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour {
    public padal padalid;
    Vector3 ballpaddiff;
    bool gamestart = false;

    // Use this for initialization
    void Start () {
       ballpaddiff = this.transform.position - padalid.transform.position;
		
	}
	
	// Update is called once per frame
	void Update () {
        if (!gamestart)
        {
            this.transform.position = padalid.transform.position + ballpaddiff;
        }
        if (Input.GetMouseButtonDown(0) && !gamestart)
        {
            gamestart = true;
            this.GetComponent<Rigidbody2D>().velocity = new Vector2(2f, 10f);
        }
    }
}
