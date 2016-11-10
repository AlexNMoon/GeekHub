using UnityEngine;
using System.Collections;

public class ChangeDoorColor : MonoBehaviour
{

    public GameObject player;
    public Material doorMaterial;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
	{
	    float distance = Vector3.Distance(player.transform.position, transform.position);
	    if (distance <= 200)
	        doorMaterial.color = Color.Lerp(Color.white, Color.red, 2 - distance/10);
	}

    void OnApplicationQuit()
    {
        doorMaterial.color = Color.white;
        ;
    }
}
