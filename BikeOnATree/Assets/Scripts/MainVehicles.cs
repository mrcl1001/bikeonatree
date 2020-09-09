using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainVehicles : MonoBehaviour
{
    public float Velociad = 20;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (ProjectProperties.Tree_Speed > 0) Velociad = ProjectProperties.Tree_Speed * 0.2f;

        this.transform.Translate(Vector3.forward * Time.deltaTime * Velociad);

        if (this.transform.position.z > ProjectProperties.Final_Tree_Position)
            this.transform.position = new Vector3(-1f, 5f, 0f);
    }
}
