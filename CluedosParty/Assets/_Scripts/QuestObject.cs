using UnityEngine;

public class QuestObject : MonoBehaviour
{
    [SerializeField] private Quest _quest;
    private bool canInteract;

    private void Start()
    {
        canInteract = false;
    }
    private void OnTriggerEnter(Collider other)
    {
        canInteract = true;
    }

    private void OnTriggerExit(Collider other)
    {
        canInteract = false; 
    }

    private void Update()
    {
        if(canInteract && Input.GetKeyDown(KeyCode.E))
        {
            _quest.CompleteTask();
        }
    }
}
