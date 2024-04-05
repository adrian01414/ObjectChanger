using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectScene : MonoBehaviour
{
    [SerializeField] private int sceneId;

    public void LoadScene(){
        SceneManager.LoadScene(sceneId);
    }
}
