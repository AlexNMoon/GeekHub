using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Assets.Scripts
{
    public class ScrollViewAnimation : MonoBehaviour {

        public Animator Animator;
        public Text Text;
        public Text ScrollViewText;
        public Button Button;

      public void ClickedAnimation(GameObject name)
        {
            if (name.GetComponent<Text>().text == "Show more")
            {
                switch (Text.text)
                {
                    case "Kurt Cobain":
                        ScrollViewText.text = "Kurt Cobain by Lucas David";
                        break;
                    case "Frances Bean Cobain":
                        ScrollViewText.text = "Frances Bean Cobain by Lucas David";
                        break;
                    case "Avril Lavigne":
                        ScrollViewText.text = "Avril Lavigne by Lucas David";
                        break;
                    case "Taylor Momsen":
                        ScrollViewText.text = "Taylor Momsen by Lucas David";
                        break;
                    default:
                        ScrollViewText.text = "";
                        break;
                }
                Animator.CrossFade("Scroll View Visible", 0f);
                name.GetComponent<Text>().text = "Close";
                EventSystem.current.SetSelectedGameObject(null);
            }
            else
            {
                Animator.CrossFade("Scroll View Invisible", 0f);
                name.GetComponent<Text>().text = "Show more";
                EventSystem.current.SetSelectedGameObject(null);
            }
        }
    }
}
