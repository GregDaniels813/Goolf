using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotatePoolCue : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
        if (Input.GetKeyDown("a"))
        {
            transform.Rotate(0, 1, 0);
        }

        if (Input.GetKeyDown("d"))
        {
            transform.Rotate(0, -1, 0);

        }

        if 
    }
}
