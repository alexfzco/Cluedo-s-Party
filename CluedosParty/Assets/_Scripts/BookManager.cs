using System.Collections;
using UnityEngine;

public class BookManager : MonoBehaviour
{
    public static BookManager Instance { get; private set; }
    [SerializeField] private float _transitionDuration;
    [SerializeField] private GameObject[] _panels;

    public GameObject[] _notes;
    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void ActivateNotes(int _note)
    {
        _notes[_note].SetActive(true);
    }

    public void Transition(GameObject Toactivate)
    {
        for(int i = 0; i<_panels.Length; i++)
        {
            _panels[i].SetActive(false);
        }
        StartCoroutine(ActivateObject(Toactivate));
    }
    
    private IEnumerator ActivateObject(GameObject Toactivate)
    {
        yield return new WaitForSeconds(_transitionDuration);
        Toactivate.SetActive(true);

    }


}
