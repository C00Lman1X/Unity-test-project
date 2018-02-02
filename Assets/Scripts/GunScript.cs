using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunScript : MonoBehaviour {

    public GameObject text;

	// Use this for initialization
	void Start () {
        Cursor.visible = false;
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(new Vector3(-Input.GetAxis("Mouse Y"), 0, -Input.GetAxis("Mouse X")) * Time.deltaTime * 10.0f);
        //text.GetComponent();
	}
}
