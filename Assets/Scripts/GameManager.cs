using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

    public GameObject LeftGreenBlock;
    public GameObject RightRedBlock;

    public int[] leftTiming;
    public int[] rightTiming;

    private AudioSource music;
    private int leftIndex;
    private int rightIndex;

	// Use this for initialization
	void Start () {
        if (GameObject.FindGameObjectWithTag("Music") != null)
        {
            GameObject item = GameObject.FindGameObjectWithTag("Music");
            music = item.GetComponent<AudioSource>();
        }
    }

    public void checkCorrect()
    {
        //when user presses the block, check if the block is colliding with the other block
        //if it is, make correct sound, give blast particle, and increment high score to 1
        //if it isn't, do nothing.
    }
	
	// Update is called once per frame
	void Update () {
        //Debug.Log("time is: " + music.time + "\n");
        if (leftIndex < leftTiming.Length)
        {
            if (Mathf.Floor(music.time) == leftTiming[leftIndex])
            {
                Instantiate(LeftGreenBlock);
                leftIndex++;
            }
        }
        if (rightIndex < rightTiming.Length)
        {
            if (Mathf.Floor(music.time) == rightTiming[rightIndex])
            {
                //Debug.Log("right index: " + rightIndex + "\n");
                Instantiate(RightRedBlock);
                rightIndex++;
            }
        }
        
	}
}
