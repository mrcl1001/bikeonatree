using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow)) {
            if (ProjectProperties.Tree_Speed < ProjectProperties.Max_Player_Velocity)
                ProjectProperties.Tree_Speed += ProjectProperties.Step_Player_Velocity;
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow)) {
            if (ProjectProperties.Tree_Speed > ProjectProperties.Min_Player_Velocity)
                ProjectProperties.Tree_Speed -= ProjectProperties.Step_Player_Velocity;
            else
                ProjectProperties.Tree_Speed = ProjectProperties.Min_Player_Velocity;
        }
    }
}
