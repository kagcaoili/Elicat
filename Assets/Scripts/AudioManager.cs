using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class AudioManager : MonoBehaviour {

    private AudioSource music;
    public bool autoStart;

    void Start()
    {
        if (GameObject.FindGameObjectWithTag("Music") != null)
        {
            GameObject item = GameObject.FindGameObjectWithTag("Music");
            music = item.GetComponent<AudioSource>();
        }

        if (autoStart)
        {
            startMusic();
        }
    }

    public void stopMusic()
    {
        music.Stop();
    }

    public void startMusic()
    {
        Debug.Log("Playing music in game\n");
        music.Play();
    }


}
