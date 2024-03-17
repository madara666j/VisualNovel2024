using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TESTING
{
    public class Testing_Architect : MonoBehaviour
    {
        DialogueSystem ds;
        TextArchitect architect;

        string[] lines = new string[5]
        {
            "Gosh, I overslept today",
            "Linda told me yesterday that Edgars was looking for me all around the school",
            "What could he have wanted from me though...?",
            "Better go find him.",
            "*More yapping to oneself*"
        };

        // Start is called before the first frame update
        void Start()
        {
            ds = DialogueSystem.instance;
            architect = new TextArchitect(ds.dialogueContainer.dialogueText);
            architect.buildMethod = TextArchitect.BuildMethod.instant;
        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                architect.Build(lines[Random.Range(0, lines.Length)]);
            }
        }
    }
}