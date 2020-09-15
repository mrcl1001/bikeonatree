using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class TreeMovementManager : MonoBehaviour
{
    public int Tree_Speed = 1;

    //private Rigidbody _rigidBody;

    // Start is called before the first frame update
    void Start()
    {
        ProjectProperties.Tree_Speed = Tree_Speed;

        //_rigidBody = GetComponent<Rigidbody>();
        //_rigidBody.constraints = RigidbodyConstraints.FreezeRotation;
    }

    // Update is called once per frame
    void Update()
    {
        //_rigidBody.AddForce(Vector3.back * Tree_Speed, ForceMode.Force);
        this.transform.Translate(Vector3.back * Time.deltaTime * ProjectProperties.Tree_Speed);

        if (this.transform.position.y < ProjectProperties.Initial_Tree_Position || 
            this.transform.position.z > ProjectProperties.Final_Tree_Position)
            Destroy(this.gameObject);

        if (this.transform.position.z < ProjectProperties.Tree_RE_Position_Penal)
            this.transform.position = 
                new Vector3(
                    this.transform.position.x,
                    this.transform.position.y,
                    ProjectProperties.Initial_Tree_RE_Position);
    }
}
