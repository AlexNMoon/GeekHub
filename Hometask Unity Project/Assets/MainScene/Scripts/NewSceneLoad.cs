using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class NewSceneLoad : MonoBehaviour
{

    void OnTriggerStay(Collider other)
    {
        SceneManager.LoadScene("HorrorLightScene");
    }

}
