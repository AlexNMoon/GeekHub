using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClosestScript : MonoBehaviour
{
    public Text text;
    private GameObject closestObject;

	void Update () {
        var objectsWithTag = GameObject.FindGameObjectsWithTag("Painting");
        foreach (GameObject obj in objectsWithTag)
        {
            if (!closestObject)
            {
                closestObject = obj;
            }
            if (Vector3.Distance(transform.position, obj.transform.position) <= Vector3.Distance(transform.position, closestObject.transform.position))
            {
                closestObject = obj;
            }
        }
	    switch (closestObject.name)
	    {
            case "Canvas1":
	            text.text = "Kurt Cobain";
                break;
            case "Canvas2":
                text.text = "Frances Bean Cobain";
                break;
            case "Canvas3":
                text.text = "Avril Lavigne";
                break;
            case "Canvas4":
                text.text = "Taylor Momsen ";
                break;
            default:
                text.text = "";
                break;

	    }
    }
}
