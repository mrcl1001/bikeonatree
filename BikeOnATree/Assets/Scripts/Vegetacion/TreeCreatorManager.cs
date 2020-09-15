using UnityEngine;

public class TreeCreatorManager : MonoBehaviour
{
    public GameObject[] treesCollection;
    public GameObject[] grassCollection;
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
        
        //ARBOLES
        for(int lado = 0; lado < ProjectProperties.Max_Num_GeneratedTrees; lado++)
        {
            for(int arbol = 0; arbol < NumMax_ByColumn; arbol++)
            {
                int rnd = Random.Range(0, treesCollection.Length);
                float dist = Random.Range(min, max);
                if (ProjectProperties.Initial_Calzada_Position < 0)
                {
                    dist = (-1 * dist);
                }
                else {
                    dist -= 8;
                }

                int rnd_z = Random.Range(-20, 20);
                Vector3 position = new Vector3(dist, ProjectProperties.Max_Height_GeneratedTrees, (z_pos+rnd_z));
                Instantiate(treesCollection[rnd], 
                            position, 
                            Quaternion.identity);
            }

            z_pos -= ProjectProperties.Max_Z_Dist_GeneratedTrees;
        }

        //HIERBA
        z_pos = ProjectProperties.Initial_Grass_Position;
        if (ProjectProperties.Initial_Calzada_Position > 0) {
            min = -18; max = -38;
        }
        else {
            min = 8; max = 28;
        }

        for (int lado = 0; lado < ProjectProperties.Max_Num_GeneratedGrass; lado++)
        {
            for (int hierba = 0; hierba < NumMax_ByColumn*2; hierba++)
            {
                int rnd = Random.Range(0, grassCollection.Length);

                float dist = Random.Range(min, max);

                int rnd_z = Random.Range(-20, 20);
                Vector3 position = new Vector3(dist, 0.08f, (z_pos+rnd_z));
                Instantiate(grassCollection[rnd],
                            position,
                            Quaternion.identity);
            }

            z_pos -= ProjectProperties.Max_Z_Dist_GeneratedTrees/3;
        }

    }
}
