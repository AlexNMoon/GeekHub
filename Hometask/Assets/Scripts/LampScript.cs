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

        // Use this for initialization
        void Start ()
        {
            StartCoroutine(Pause());
        }

        void OnTriggerStay(Collider other)
        {
            if (!Input.GetKeyDown(KeyCode.Return)) return;
            SafeMode = !SafeMode;
            if (!SafeMode)
            {
                StartCoroutine(Pause());
            }
        }

        private IEnumerator Pause()
        {
            var rotation = new Vector3(70, 0, 0);
            while (!SafeMode)
            {
                Lamp.transform.DORotate(rotation, 1, RotateMode.Fast);
                //Lamp.transform.Rotate(rotation);
                rotation.x = -rotation.x;
                yield return new WaitForSeconds(Random.Range(0.1f, 0.75f));
                Spotlight.GetComponent<Light>().intensity = Random.Range(0f, 5f);
            }
            Spotlight.GetComponent<Light>().intensity = 5;
            Lamp.transform.DORotate(new Vector3(0, 0, 0), 1, RotateMode.Fast);
        }

    }
}
