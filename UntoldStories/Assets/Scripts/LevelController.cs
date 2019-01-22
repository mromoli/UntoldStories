using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour {

	public int choiche = 1;
	public DialogueTrigger example2;
	public DialogueTrigger prova;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		
			switch (choiche)
			{
				case 1:
					choiche = 0;
					example2.TriggerDialogue();
					break;
				case 2:
					choiche = 0;
					prova.TriggerDialogue();
					break;

			}
		
		
	}

	
}
