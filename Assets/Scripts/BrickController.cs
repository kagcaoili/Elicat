using UnityEngine;
using System.Collections;

public class BrickController : MonoBehaviour {

    private bool hit;
    private GameObject savedBlock;
    public GameObject score;

	// Use this for initialization
	void Start () {

    }

    public void checkCollision()
    {
        if (hit)
        {
            Debug.Log("collide with hit\n");
            Destroy(savedBlock);
            string textScore = score.GetComponent<TextMesh>().text;
            int scoreNumber = int.Parse(textScore) + 1;
            score.GetComponent<TextMesh>().text = scoreNumber.ToString();
        }
    }

    void OnCollisionEnter (Collision col)
    {
        if (col.gameObject.tag == "block")
        {
            Debug.Log("block entered\n");
            hit = true;
            savedBlock = col.gameObject;
        } 
    }

    void OnCollisionExit (Collision col)
    {
        if (col.gameObject.tag == "block")
        {
            Debug.Log("block exited\n");
            hit = false;
            savedBlock = null;
        }
    }
	
	// Update is called once per frame
	void Update () {
        
	}
}
