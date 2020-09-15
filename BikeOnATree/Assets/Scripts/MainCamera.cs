using UnityEngine;

public class MainCamera : MonoBehaviour
{
    public GameObject player;
    private Vector3 _offset;
    private float _turnSpeed = 90;

    private bool _rightView = true;
    private bool _leftView = true;

    // Start is called before the first frame update
    void Start()
    {
        _offset = new Vector3(0f, 1.5f, player.transform.position.z - 65f);

        this.transform.position = player.transform.position + _offset;
    }

    // Update is called once per frame
    void Update()
    {
        /*if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow)) {
            _rightView = false;
            _leftView = false;

            if (Input.GetKey(KeyCode.RightArrow) && this.transform.rotation.eulerAngles.y < 100f) {
                _leftView = true;
            }
            else if (Input.GetKey(KeyCode.LeftArrow) && this.transform.rotation.eulerAngles.y > -100f) {
                _rightView = true;
            }

            if (_rightView || _leftView) {
                this.transform.Rotate(Input.GetAxis("Horizontal") * Time.deltaTime * Vector3.up * _turnSpeed);
            }
        }*/
        this.transform.Rotate(Input.GetAxis("Horizontal") * Time.deltaTime * Vector3.up * _turnSpeed);
    }
}
