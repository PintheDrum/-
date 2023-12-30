using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DialogueDisplayer : MonoBehaviour
{
    [SerializeField] private GameObject speakerBox;
    [SerializeField] private TMP_Text speakerName;
    [SerializeField] private GameObject dialogueBox;
    [SerializeField] private TMP_Text dialogueText;
    [SerializeField] private GameObject panel;
    public DialogueObject currentDialogue;


    private void Start()
    {
        DisplayDialogue(currentDialogue);
    }

    private IEnumerator MoveThroughDialogue(DialogueObject dialogueObject)
    {
        for (int i = 0; i < dialogueObject.dialogueLines.Length; i++)
        {
            speakerName.text = dialogueObject.dialogueLines[i].speaker;
            dialogueText.text = dialogueObject.dialogueLines[i].dialogue;

            //The following line of code makes it so that the for loop is paused until the user clicks the left mouse button.
            yield return new WaitUntil(() => Input.GetMouseButtonDown(0));
            //The following line of codes make the coroutine wait for a frame so as the next WaitUntil is not skipped
            yield return null;
        }
        panel.SetActive(false);//改成切换场景
    }

    public void DisplayDialogue(DialogueObject dialogueObject)
    {
        StartCoroutine(MoveThroughDialogue(dialogueObject));
    }
}