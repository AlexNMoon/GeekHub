using UnityEngine;
using UnityEngine.UI;
using System.Collections;

namespace Assets.Scripts
{
    public class PinDownCountScript : MonoBehaviour
    {

        public Text CountText;
        private int _count;
       

        void OnTriggerEnter(Collider other)
        {
            if (other.tag == "pin")
                {
                    ShowScore();
                }
            }

        void ShowScore()
        {
            _count = int.Parse(CountText.text);
           _count++;
            CountText.text = _count.ToString();
        }

        
    }
}
