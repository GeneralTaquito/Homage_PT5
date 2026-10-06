using TMPro;
using UnityEngine;

public class Sleeping : MonoBehaviour
{
    public Bed_Script bedScript;
    public GameObject Sun;
    public GameObject popUp;
    public TextMeshProUGUI DayCheck;

    public Days currentDay = Days.Monday;
    public enum Days
    {
        none = 0,
        Monday = 1,
        Tuesday = 2,
        Wednesday = 3,
    }
    private void Start()
    {
        popUp.SetActive(false);
        DayCheck.text = ("Day: " + currentDay.ToString());
    }

    private void Update()
    {
        switch (currentDay) // changing directional light (sun)
        {
            case Days.Monday:
                Sun.transform.rotation = Quaternion.Euler(3f, 0f, 0f);
                break;

            case Days.Tuesday:
                Sun.transform.rotation = Quaternion.Euler(45f, 0f, 0f);
                break;

            case Days.Wednesday:
                Sun.transform.rotation = Quaternion.Euler(170f, 0f, 0f);
                break;
        }
    }
    private void OnMouseOver() //for popup interaction
    {
        if (bedScript.inRange)
        {
            popUp.SetActive(true);
        }
    }

    private void OnMouseDown() // for changing the day
    {
        if (bedScript.inRange) 
        {
            changeDay();
            DayCheck.text = ("Day: " + currentDay.ToString());
        }
    }

    private void OnMouseExit() //for popup interaction
    {
        popUp.SetActive(false);
    }


    void changeDay() //changing day
    {
        if (currentDay == Days.Monday)
        {
            currentDay = Days.Tuesday;
        }
        else if (currentDay == Days.Tuesday)
        {
            currentDay = Days.Wednesday;
        }
        else 
        {
            currentDay = Days.Monday;
        }
    }
}
