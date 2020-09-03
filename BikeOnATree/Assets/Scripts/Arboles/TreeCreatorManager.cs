using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeCreatorManager : MonoBehaviour
{
    public GameObject[] gameObjectCollection;
    public int NumMax_ByColumn = 6;
    public float X_Initial_Position = -34f;

    // Start is called before the first frame update
    void Start()
    {
        CreateRandomTreesByColumn();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void CreateRandomTreesByColumn()
    {        
        float z_pos = 485f;
        Random random = new Random();

        for(int lado = 0; lado < 50; lado++)
        {
            float x_pos = X_Initial_Position;

            for(int arbol = 0; arbol < NumMax_ByColumn; arbol++)
            {
                //System.Random rand = new System.Random(); 
                int rnd = 0;//rand.Next(0, 6);

                Vector3 position = new Vector3(x_pos, 2.4f, z_pos);
                Instantiate(gameObjectCollection[rnd], position, gameObjectCollection[rnd].transform.rotation);
                x_pos += 3f;
            }

            z_pos -= 13f;
        }
    }
}
