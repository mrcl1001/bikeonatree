using UnityEngine;

public class TerrainMovementManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(Vector3.back * Time.deltaTime * ProjectProperties.Tree_Speed);

        if (this.transform.position.z < -1000)
            this.transform.position =
                new Vector3(
                    this.transform.position.x,
                    this.transform.position.y,
                    990);
    }
}
