using UnityEngine;

public class MainCamera : MonoBehaviour
{
    public GameObject player;
    private Vector3 _offset;
    private float _horizontalView;
    private float _turnSpeed = 90;

    // Start is called before the first frame update
    void Start()
    {
        _offset = new Vector3(0f, 1.5f, -1.5f);

        this.transform.position = player.transform.position + _offset;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow)) {
            _horizontalView = Input.GetAxis("Horizontal");
            this.transform.Rotate(_horizontalView * Time.deltaTime * Vector3.up * _turnSpeed);
        }
    }
}
