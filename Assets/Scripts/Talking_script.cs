using System;
using System.Collections;
using TMPro;
using UnityEngine;

public class Talking_script : MonoBehaviour
{
    public NpcCol_script npcCol;
    public TextMeshProUGUI dialoguebox;
    public string[] lines;
    public string[] lines2;
    public string[] lines3;
    private int index;
    public Sleeping sleeping;


    void Start()
    {
        index = 0;
        dialoguebox.text = string.Empty;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && npcCol.DialogueRange)
        {
            switch (sleeping.currentDay) // for each day there will be a new dialogue line
            {
                case Sleeping.Days.Monday:
                    if (dialoguebox.text == lines[index])
                    {
                        NextDialogue();
                    }
                    else
                    {
                        StopAllCoroutines();
                        dialoguebox.text = lines[index];
                    }
                    break;
                case Sleeping.Days.Tuesday:
                    if (dialoguebox.text == lines2[index])
                    {
                        NextDialogue2();
                    }
                    else
                    {
                        StopAllCoroutines();
                        dialoguebox.text = lines2[index];
                    }
                    break;
                case Sleeping.Days.Wednesday:
                    if (dialoguebox.text == lines3[index])
                    {
                        NextDialogue3();
                    }
                    else
                    {
                        StopAllCoroutines();
                        dialoguebox.text = lines3[index];
                    }
                    break;
            }
        }
        else if (!npcCol.DialogueRange)
        {
            Debug.Log("brokn");
            index = 0;
            dialoguebox.text = string.Empty;
        }
    }

    void NextDialogue() //continuing dialogue 
    {
        if (index < lines.Length - 1) 
        {
            index++;
            dialoguebox.text = string.Empty;
        }
        else //reset exhausted dialogue
        {
            index = 0;
        }
    }
    void NextDialogue2() //continuing dialogue 
    {
        if (index < lines2.Length - 1)
        {
            index++;
            dialoguebox.text = string.Empty;
        }
        else //reset exhausted dialogue
        {
            index = 0;
        }
    }
    void NextDialogue3() //continuing dialogue 
    {
        if (index < lines3.Length - 1)
        {
            index++;
            dialoguebox.text = string.Empty;
        }
        else //reset exhausted dialogue
        {
            index = 0;
        }
    }

}
