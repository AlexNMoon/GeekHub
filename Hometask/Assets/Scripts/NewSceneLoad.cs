using System;
using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class NewSceneLoad : MonoBehaviour
{

    public String sceneName;
   

    void OnTriggerStay(Collider other)
    {
        SceneManager.LoadScene(sceneName);
        
    }

}
