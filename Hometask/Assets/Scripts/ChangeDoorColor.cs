using UnityEngine;

namespace Assets.Scripts
{
    public class ChangeDoorColor : MonoBehaviour
    {

        public GameObject Player;
        public Material DoorMaterial;

        void Update ()
        {
            var distance = Vector3.Distance(Player.transform.position, transform.position);
            DoorMaterial.color = Color.Lerp(Color.red, Color.white,  distance/5);
        }

        void OnApplicationQuit()
        {
            DoorMaterial.color = Color.white;
            ;
        }
    }
}
