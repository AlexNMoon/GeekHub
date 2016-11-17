using UnityEngine;
using System.Collections;
using DG.Tweening;

public class LampScript : MonoBehaviour
{

    public bool safeMode;
    public GameObject lamp;

	// Use this for initialization
	void Start ()
    {
        DOTween.Init();
        lampMode();
	}

    void OnTrigerEnter (Collider other)
    {
        if (Input.GetButton("Submit"))
        {
            safeMode = !safeMode;
            lampMode();
        }
    }

    void lampMode()
    {
        if (!safeMode)
        {
            
        }
    }
}
