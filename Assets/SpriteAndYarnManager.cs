using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class SpriteAndYarnManager : MonoBehaviour
{

    public DialogueRunner runner;
    public GameObject MrDocken;
    public GameObject Nova;

    // Start is called before the first frame update
    void Start()
    {
        runner.StartDialogue("MrDocken");
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!runner.IsDialogueRunning)
        {
            runner.StartDialogue("Nova");
            Nova.SetActive(true);
            MrDocken.SetActive(false);
        }
    }
}
