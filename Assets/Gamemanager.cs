using UnityEngine;

public class Gamemanager : MonoBehaviour
{
    public bool isMenuOpen = false;
    [SerializeField] private Canvas menu;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Cancel")) {
            isMenuOpen = !isMenuOpen;
        }
        if (isMenuOpen) {
            menu.enabled = true;
        } else { 
            menu.enabled = false; 
        }
    }
}
