using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class SpriteAndYarnManager : MonoBehaviour
{

    public DialogueRunner runner;
    public GameObject MrDocken;
    public GameObject Nova;
    int counter = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if ((!runner.IsDialogueRunning)&&counter==0)
        {
            runner.StartDialogue("MrDocken");
            MrDocken.SetActive(true);
            counter++;
        }
        else if ((!runner.IsDialogueRunning)&& counter!=0)
        {
            runner.StartDialogue("Nova");
            Nova.SetActive(true);
            MrDocken.SetActive(false);
        }

    }
}
