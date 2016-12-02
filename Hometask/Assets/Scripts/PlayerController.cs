using UnityEngine;

namespace Assets.Scripts
{
    public class PlayerController : MonoBehaviour {

        public float MoveSpeed;
        public float RotateSpeed;

       void Update ()
        {
            var translate = Input.GetAxis("Vertical")*MoveSpeed*Time.deltaTime;
            var rotate = Input.GetAxis("Horizontal")*RotateSpeed*Time.deltaTime;
            transform.Translate(0f, 0f, translate);
            transform.Rotate(0f, rotate, 0f);
        }

   
    }
}
