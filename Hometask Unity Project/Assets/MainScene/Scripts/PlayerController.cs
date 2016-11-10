using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    public float moveSpeed = 3f;
    public float rotateSpeed = 20f;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
	{
	    float translate = Input.GetAxis("Vertical")*moveSpeed*Time.deltaTime;
	    float rotate = Input.GetAxis("Horizontal")*rotateSpeed*Time.deltaTime;
        transform.Translate(0f, 0f, translate);
	    transform.Rotate(0f, rotate, 0f);
	}

   
}
