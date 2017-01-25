using UnityEngine;
using UnityEngine.UI;
using System.Collections;

namespace Assets.Scripts
{
    public class PinDownCountScript : MonoBehaviour
    {

        public Text CountText;
        private int _count;
        private bool[] counted;
        public GameObject PinsPrefab;
        public GameObject BallPrefab;

        void Start()
        {
            counted = new bool[10];
            Restart();
        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetButtonDown("Cancel"))
            {
                CountText.text = "0";
                Restart();
                Destroy(GameObject.FindGameObjectWithTag("Pins"));
                Destroy(GameObject.FindGameObjectWithTag("Ball"));
                GameObject Pins = (GameObject)Instantiate(PinsPrefab, new Vector3(1.82f, 1.19f, -0.9f), Quaternion.identity);
                GameObject Ball = (GameObject)Instantiate(BallPrefab, new Vector3(1.7f, 1.25f, -1.85f), Quaternion.identity);
            }
        }
        
        void OnTriggerEnter(Collider other)
        {
            if (other.tag == "pin")
                {
                    for (int i = 1; i < 11; i++)
                    {
                        if ((other.name == i.ToString()) && (!counted[i-1]))
                        {
                            ShowScore();
                            counted[i - 1] = true;
                        }
                    }
                }
            }

        void ShowScore()
        {
            _count = int.Parse(CountText.text);
           _count++;
            CountText.text = _count.ToString();
        }

        void Restart()
        {
            for (int i = 0; i < 10; i++)
            {
                counted[i] = false;
            }
        }
    }
}
