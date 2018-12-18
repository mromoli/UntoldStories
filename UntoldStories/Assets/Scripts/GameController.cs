using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

    public float timer = 60f;
    public float tMultiplier = 1f;
	private bool buttonPressed = false;
	public GameObject frame;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        tMultiplier -= Time.deltaTime / timer;
		if (buttonPressed)
		{
			speedTime();
			if(tMultiplier <= 0)
			{
				Destroy(frame);
			}
		}
    }

	public void speedTime()
	{
		buttonPressed = true;
		tMultiplier -= 0.01f;
		
	}
}
