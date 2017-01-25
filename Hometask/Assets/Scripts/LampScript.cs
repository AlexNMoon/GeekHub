using System.Collections;
using UnityEngine;
using DG.Tweening;

namespace Assets.Scripts
{
    public class LampScript : MonoBehaviour
    {

        public bool SafeMode;
        public GameObject Lamp;
        public GameObject Spotlight;
        private bool _triggerEntered;

        void Start ()
        {
            _triggerEntered = false;
            StartCoroutine(Flickering());
        }

        void Update()
        {
            if (Input.GetButtonDown("Submit") && _triggerEntered)
            {
                SafeMode = !SafeMode;
                Debug.Log("Safe mode changed.");
                if (!SafeMode)
                {
                    StartCoroutine(Flickering());
                }
            }
        }

        void OnTriggerEnter(Collider other)
        {
            Debug.Log("On triger enter.");
            _triggerEntered = true;
            
        }

        void OnTriggerExit(Collider other)
        {
            _triggerEntered = false;
        }

        private IEnumerator Flickering()
        {
            Sequence sequence = DOTween.Sequence();
            sequence.Append(Lamp.transform.DORotate(new Vector3(30, 0, 0), 3))
                .Append(Lamp.transform.DORotate(new Vector3(-30, 0, 0), 3))
                .Append(Lamp.transform.DORotate(new Vector3(0, 0, 0), 3))
                .SetLoops(-1);
           while (!SafeMode)
            {
                yield return new WaitForSeconds(Random.Range(0.1f, 0.75f));
                Spotlight.GetComponent<Light>().intensity = Random.Range(0f, 5f);
            }
            sequence.Kill();
            Spotlight.GetComponent<Light>().intensity = 5f;
            Lamp.transform.DORotate(new Vector3(0, 0, 0), 1);
        }

    }
}
