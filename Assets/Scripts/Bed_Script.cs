using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Bed_Script : MonoBehaviour
{
    public GameObject Sun;
    public TextMeshProUGUI Popup;
    public bool Day;
    public bool Night;
    private bool inRange;

    private void Start()
    {
        Popup.gameObject.SetActive(false);
        if(Day)
        {

        }
    }

    private void Update()
    {
        if(inRange)
        {

        }
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            inRange = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            inRange = false;
        }
    }


    private void OnMouseDown()
    {
        Debug.Log("Changing time");

    }

    private void OnMouseOver()
    {

        Popup.gameObject.SetActive(true);
    }

    private void OnMouseExit()
    {
        Popup.gameObject.SetActive(false);
    }
}
