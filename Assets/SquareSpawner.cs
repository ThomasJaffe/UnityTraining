using UnityEngine;

public class SquareSpawner : MonoBehaviour
{
    [SerializeField] private GameObject original;

    // Start is called before the first frame update
    void Start() {
        for (int i = 0; i < 8; i++) {
            for (int j = 0; j< 8; j++) {
                Instantiate(original, original.transform.position + new Vector3(i, j), Quaternion.identity,transform);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
