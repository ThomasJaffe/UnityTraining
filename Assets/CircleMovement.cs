using UnityEngine;

public class CircleMovement : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    static private float maxY = 4.5f;
    static private float minY = -1 * maxY;
    static private float maxX = (maxY * 16 / 9) + 0.4f;
    static private float minX = -1 * maxX;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector2(-8,0);
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal"); // Horizontal axis
        float vertical = Input.GetAxis("Vertical"); // Vertical axis

        Vector3 movement = new(horizontal,vertical);

        transform.position += speed * Time.deltaTime * movement;
    }
}
