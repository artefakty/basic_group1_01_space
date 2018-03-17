using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FighterBehavior : MonoBehaviour
{

    public float Speed = 1.0f;
    public float Rotation = 100.0f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
        this.transform.Translate(0.0f, 0.0f, Speed * Time.deltaTime);
	    if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
	    {
	        this.transform.Rotate(0.0f, -Rotation * Time.deltaTime, 0.0f);
        }
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            this.transform.Rotate(0.0f, Rotation * Time.deltaTime, 0.0f);
        }


    }
}
