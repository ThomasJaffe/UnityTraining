using UnityEngine;

public class Gamemanager : MonoBehaviour
{
    public bool isMenuOpen = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            isMenuOpen = !isMenuOpen;
        }
    }
}
