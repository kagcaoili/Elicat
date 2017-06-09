using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class NextScene : MonoBehaviour {

    public AudioSource music;
    public GameObject volumeIcon;
    public GameObject muteIcon;
    public int scene;
    public static bool initialStart = true;
    
    void Awake()
    {
        Debug.Log("runs awake\n");
        if (GameObject.FindGameObjectWithTag("Music") == null)
        {
            music = (AudioSource) Instantiate(music, new Vector3(0, 0, 0), Quaternion.identity);
            DontDestroyOnLoad(music);
        } else
        {
            music = GameObject.FindGameObjectWithTag("Music").GetComponent<AudioSource>();
        }
    }

    void Start()
    {
        Debug.Log("runs start\n");
        //if (!music.isPlaying && volumeIcon.activeInHierarchy)
        if (initialStart)
        {
            Debug.Log("detected inital start\n");
            music.Play();
            initialStart = false;
        } else
        {
            if (!music.isPlaying)
            {
                muteIcon.SetActive(true);
                volumeIcon.SetActive(false);
            } 
        }
    }

    public void LoadLevel()
    {
        SceneManager.LoadScene(scene);
    }

}
