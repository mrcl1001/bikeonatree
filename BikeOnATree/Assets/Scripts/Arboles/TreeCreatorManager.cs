using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeCreatorManager : MonoBehaviour
{
    public GameObject[] gameObjectCollection;
    public int NumMax_ByColumn = 6;
    public int Size_Position = -1;

    // Start is called before the first frame update
    void Start()
    {
        ProjectProperties.Initial_Calzada_Position = Size_Position;

        CreateRandomTreesByColumn();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void CreateRandomTreesByColumn()
    {        
        float z_pos = ProjectProperties.Initial_Calzada_Z_Position;
        int min = ProjectProperties.Weight_Min;
        int max = ProjectProperties.Weight_Max;        

        for(int lado = 0; lado < ProjectProperties.Max_Num_GeneratedTrees; lado++)
        {
            for(int arbol = 0; arbol < NumMax_ByColumn; arbol++)
            {
                int rnd = Random.Range(0, 4);
                float dist = Random.Range(min, max);
                if (ProjectProperties.Initial_Calzada_Position < 0){
                    dist = -1 * dist;
                }

                Vector3 position = new Vector3(dist, ProjectProperties.Max_Height_GeneratedTrees, z_pos);
                Instantiate(gameObjectCollection[rnd], 
                            position, 
                            Quaternion.identity);
            }

            z_pos -= ProjectProperties.Max_Z_Dist_GeneratedTrees;
        }
    }
}
