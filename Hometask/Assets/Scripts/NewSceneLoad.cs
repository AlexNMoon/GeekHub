using UnityEngine;
using UnityEngine.SceneManagement;

namespace Assets.Scripts
{
    public class NewSceneLoad : MonoBehaviour
    {

        public string SceneName;
   
        void OnTriggerStay(Collider other)
        {
            SceneManager.LoadScene(SceneName);
        
        }

    }
}
