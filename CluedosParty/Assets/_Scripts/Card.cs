using UnityEngine;
using UnityEngine.UIElements;

[RequireComponent(typeof(BoxCollider))]
public class Card : MonoBehaviour
{
    [SerializeField] private Puerta _door;
    private BoxCollider _trigger;

    private void Start()
    {
        _trigger = GetComponent<BoxCollider>();
        _trigger.isTrigger = true;
    }

    private void OnTriggerEnter(Collider other)
    {
        _door.UnlockDoor();
        Destroy(gameObject, 1);
    }
}
