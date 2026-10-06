using UnityEngine;

public class NpcCol_script : MonoBehaviour
{
    public bool DialogueRange;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            DialogueRange = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            DialogueRange = false;
        }
    }
}
