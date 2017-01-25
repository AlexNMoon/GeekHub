using UnityEngine;

namespace Assets.Scripts
{
    public class BallThrowerScript : MonoBehaviour
    {

        private int _force = 0;
    
        // Update is called once per frame
        void Update () {

            if (Input.GetButtonDown("Fire1"))
            {
                _force = _force + 20;
            }
            if (Input.GetButtonUp("Fire1"))
            {
                GetComponent<Rigidbody>().AddForce(Vector3.forward * _force, ForceMode.Acceleration);
            }
	    
        }
    }
}
