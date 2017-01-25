using UnityEngine;
using System.Collections;
using DG.Tweening;

public class BondariesScript : MonoBehaviour {

    private bool _bondaryOn = true;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Jump"))
        {
            if (_bondaryOn)
            {
                transform.DOScaleY(0.5f, 10f);
                transform.DOMoveY(0.588f, 10f);
                _bondaryOn = false;
            }
            else
            {
                transform.DOScaleY(1f, 10f);
                transform.DOMoveY(-0.001f, 10f);
                _bondaryOn = true;
            }
        }
    }
}
