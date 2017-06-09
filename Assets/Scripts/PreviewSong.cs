using UnityEngine;
using System.Collections;

public class PreviewSong : MonoBehaviour {

    private AudioSource music;
    public AudioClip[] songs;

    void Start()
    {
        GameObject musicManager = GameObject.FindGameObjectWithTag("Music");
        music = musicManager.GetComponent<AudioSource>();
    }

	public void previewSong(int song)
    {
        stopMusic();

        music.clip = songs[song];
        music.Play();
    }

    public void stopMusic()
    {
        if (music.isPlaying)
        {
            music.Stop();
        }
    }




}
