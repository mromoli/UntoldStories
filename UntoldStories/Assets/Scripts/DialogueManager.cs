using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour {

	//tiene traccia delle frasi del dialogo corrente
	private Queue<string> sentences;
	public Text nameText;
	public Text dialogueText;
	public Animator animator;

	// Use this for initialization
	void Start () {

		sentences = new Queue<string>();
	}
	
	public void StartDialogue(Dialogue dialogue)
	{
		animator.SetBool("isOpen", true);
		nameText.text = dialogue.name;
		sentences.Clear();
		//inserisce le frasi nella coda
		foreach ( string sentence in dialogue.sentences)
		{
			sentences.Enqueue(sentence);
		}

		DisplayNextSentence();
	}

	//controlla se ci sono alter frasi presenti, se no, termina la conversazione
	public void DisplayNextSentence()
	{
		if(sentences.Count == 0)
		{
			EndDialogue();
			return;
		}

		string sentence = sentences.Dequeue();
		StopAllCoroutines();
		StartCoroutine(TypeSentence(sentence));
	}

	IEnumerator TypeSentence(string sentence)
	{
		dialogueText.text = "";
		foreach (char letter in sentence.ToCharArray())
		{
			dialogueText.text += letter;
			yield return null;
		}
	}

	public void EndDialogue()
	{
		animator.SetBool("isOpen", false);
	}
}
