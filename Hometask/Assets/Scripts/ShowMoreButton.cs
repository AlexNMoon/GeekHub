using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts
{
    public class ShowMoreButton : MonoBehaviour
    {

        public Button Button;
        private Animator _animator;
    
        void Start()
        {
            _animator = Button.GetComponent<Animator>();
        }

        void OnTriggerEnter(Collider other)
        {
            _animator.CrossFade("Triggered", 0f);
        }

        void OnTriggerExit(Collider other)
        {
            _animator.CrossFade("Normal", 0f);
        }

    }
}
