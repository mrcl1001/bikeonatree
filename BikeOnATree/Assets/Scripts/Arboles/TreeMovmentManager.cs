using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class TreeMovmentManager : MonoBehaviour
{
    public int Tree_Speed = 10;

    private Rigidbody _rigidBody;

    // Start is called before the first frame update
    void Start()
    {
        _rigidBody = GetComponent<Rigidbody>();
        //_rigidBody.constraints = RigidbodyConstraints.FreezeRotation;
    }

    // Update is called once per frame
    void Update()
    {
        //_rigidBody.AddForce(Vector3.back * Tree_Speed, ForceMode.Force);
        this.transform.Translate(Vector3.back * Time.deltaTime * Tree_Speed);

        if (this.transform.position.y < 0)
            Destroy(this.gameObject);
    }
}
