using UnityEngine;

public class Quest : MonoBehaviour
{
    [SerializeField] private GameObject _questObject;
    private bool _questCompleted;

    private void Start()
    {
        _questCompleted = false;
    }
    

    public void CompleteTask()
    {
        _questCompleted = true;
    }
}
