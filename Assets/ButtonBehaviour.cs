using UnityEngine;

public class ButtonBehaviour : MonoBehaviour
{
    [SerializeField] Gamemanager Manager;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Reprendre() {
        Manager.isMenuOpen = false;
    }

    public void Quitter() {
        Application.Quit();
    }

}
