using UnityEngine;
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
                        ScrollViewText.text = "Kurt Cobain";
                        break;
                    case "Frances Bean Cobain":
                        ScrollViewText.text = "Frances Bean Cobain";
                        break;
                    case "Avril Lavigne":
                        ScrollViewText.text = "Avril Lavigne";
                        break;
                    case "Taylor Momsen":
                        ScrollViewText.text = "Taylor Momsen ";
                        break;
                    default:
                        ScrollViewText.text = "";
                        break;
                }
                Animator.CrossFade("Scroll View Visible", 0f);
            }
            else
            {
                Animator.CrossFade("Scroll View Invisible", 0f);
            }
        }
    }
}
