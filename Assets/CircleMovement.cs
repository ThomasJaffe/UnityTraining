using UnityEngine;

public class CircleMovement : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    [SerializeField] private Gamemanager Manager;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector2(-8,0);
    }

    // Update is called once per frame
    void Update()
    {
        if (!Manager.isMenuOpen) {
            float horizontal = Input.GetAxis("Horizontal"); // Horizontal axis
            float vertical = Input.GetAxis("Vertical"); // Vertical axis

            Vector3 movement = new(horizontal, vertical);

            transform.position += speed * Time.deltaTime * movement;
        }
    }
}
