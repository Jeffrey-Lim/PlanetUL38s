using UnityEngine;
using System.Collections;

public class DialogueTrigger : MonoBehaviour {
	private Dialogue dialogue;
	private bool isTriggered = false;
	private DialogueManager manager;

	void Awake () {
		manager = FindObjectOfType<DialogueManager> ();
		dialogue = GetComponent<Dialogue> ();
	}

	void OnTriggerEnter (Collider col) {
		if (col.name == "Player" && isTriggered == false) {
			isTriggered = true;
			manager.StartDialogue (dialogue.data, dialogue);
		}
	}
}
