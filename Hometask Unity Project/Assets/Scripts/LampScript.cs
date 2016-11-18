using UnityEngine;
using System.Collections;
using DG.Tweening;

public class LampScript : MonoBehaviour
{

    public bool safeMode;
    public GameObject lamp;
    public GameObject spotlight;
    private bool Change;

	// Use this for initialization
	void Start ()
	{
	    Change = true;
        StartCoroutine(Pause());
    }

    void OnTriggerStay(Collider other)
    {
        Debug.Log("Entered Triger");
        if (Input.GetKey(KeyCode.Return))
        {
            Debug.Log("Pressed Enter");
            safeMode = !safeMode;
            Change = true;

        }
    }



    IEnumerator Pause()
    {
        while (true)
        {
            if (Change)
            {

                Change = false;
                if (!safeMode)
                {
                    Debug.Log("Scary mode");
                    
                    

                        yield return new WaitForSeconds(0.5F);
                        spotlight.GetComponent<Light>().enabled = !spotlight.GetComponent<Light>().enabled;
                    
                }
                else spotlight.GetComponent<Light>().enabled = true;

            }
        }
    }
}
