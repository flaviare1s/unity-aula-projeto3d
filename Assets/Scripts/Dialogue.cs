using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialogue : MonoBehaviour
{
    public string[] speechText;
    public string actorName;

    private DialogueControl dialogueControl;
    private bool onRadious;
    private bool isDialogueActive = false;

    public LayerMask playerLayer;
    public float radious;


    void Start()
    {
        dialogueControl = FindObjectOfType<DialogueControl>();
    }

    private void FixedUpdate()
    {
        Interact();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && onRadious && !isDialogueActive)
        {
            StartDialogue();
        }
    }

    private void StartDialogue()
    {
        isDialogueActive = true;
        dialogueControl.Speech(speechText, actorName);
        Debug.Log("Diálogo iniciado com " + actorName);
    }

    private void EndDialogue()
    {
        isDialogueActive = false;
        Debug.Log("Diálogo finalizado com " + actorName);
    }

    public void Interact()
    {
        Vector3 point1 = transform.position + Vector3.up * radious;
        Vector3 point2 = transform.position - Vector3.up * radious;

        Collider[] hits = Physics.OverlapCapsule(point1, point2, radious, playerLayer);

        if (hits.Length > 0)
        {
            if (!onRadious)
            {
                Debug.Log("Entrou no radious");
            }

            onRadious = true;
            // Animação aqui, true (caso deseje colocar alguma animação)

        }
        else
        {
            if (onRadious) 
            {
                Debug.Log("Saiu do radious");
            }

            onRadious = false;

            if (!isDialogueActive)
            {
                EndDialogue();
            }
        }
    }
}
