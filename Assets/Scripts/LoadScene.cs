using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour {

    public int scene;
    

    public void LoadLevel()
    {
        SceneManager.LoadScene(scene);
    }

}
