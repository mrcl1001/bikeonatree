using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class GrassMovementManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(Vector3.back * Time.deltaTime * ProjectProperties.Tree_Speed);

        if (this.transform.position.z < ProjectProperties.Final_Grass_Position)
            this.transform.position =
                new Vector3(
                    this.transform.position.x,
                    this.transform.position.y,
                    ProjectProperties.Initial_Grass_Position);
    }
}
