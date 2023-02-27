using UnityEngine;

public class CircleBehaviour : MonoBehaviour
{
    private SpriteRenderer _renderer;
    private Color _baseColor;
    private GameObject _toDestroy;
    // Start is called before the first frame update
    void Start() {
        _renderer = GetComponent<SpriteRenderer>();
        _baseColor = _renderer.color;
    }

    // Update is called once per frame
    void Update()  {
        if (Input.GetButton("Jump")) {
            _renderer.color = Color.red;
        } else if (Input.GetButtonUp("Jump")){
            _renderer.color = _baseColor;
            Destroy(_toDestroy);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        _toDestroy = collision.gameObject;
    }
}