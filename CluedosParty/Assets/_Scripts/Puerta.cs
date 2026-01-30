using UnityEngine;

public class Puerta : MonoBehaviour
{
    [SerializeField] private string _animatorState;
    private Animator animator;
    private bool isLocked;
    private bool canInteract;

    private void Start()
    {
        isLocked = false;
        animator = GetComponent<Animator>();
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
        if (Input.GetKeyDown(KeyCode.E) && canInteract)
        {
            if (isLocked)
            {
                ///Funcionalidad de cuando esta bloqueada
            }
            else
            {
                animator.CrossFadeInFixedTime(_animatorState, 0.5f);
            }
        }
    }

    public void UnlockDoor()
    {
        isLocked = false;
    }
}
