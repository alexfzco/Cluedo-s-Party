using UnityEngine;

public class UIManager : MonoBehaviour
{
    private bool isGamePaused;
    [SerializeField] private GameObject noteboard;

    private void Start()
    {
        isGamePaused = false;
        
    }

    private void Update()
    {
        
    }

    private void OpenCloseMenu(bool paused)
    {
        if (paused)
        {
            //Despausar
            Time.timeScale = 1.0f;
            
            
           
        }
    }



}
