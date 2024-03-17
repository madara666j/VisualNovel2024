using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogueSystem : MonoBehaviour
{
    public DialogueContainer dialogueContainer; // new DialogueContainer();
    
    public static DialogueSystem instance;
    // Start is called before the first frame update
    void Start()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            DestroyImmediate(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
