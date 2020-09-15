
using UnityEngine.UIElements.Experimental;

public class ProjectProperties
{
    /// <summary>
    /// TREES PROPERTIES
    /// </summary>
    #region TREES PROPERTIES
    public static float Initial_Tree_Position = 0f;
    public static float Final_Tree_Position = 800f;
    public static float Initial_Tree_RE_Position = 800f;
    public static float Tree_RE_Position_Penal = 300f;

    /// <summary>
    /// GRASS PROPERTIES
    /// </summary>
    public static float Initial_Grass_Position = 800f;
    public static float Final_Grass_Position = 300f;


    public static int Tree_Speed { get; set; }
    #endregion

    /// <summary>
    /// CALZADA PROPERTIES
    /// </summary>
    #region CALZADA PROPERTIES
    public static float Initial_Calzada_Z_Position = 800f;
    public static int Weight_Min = 16;
    public static int Weight_Max = 40;
    public static int Max_Num_GeneratedTrees = 50;
    public static int Max_Num_GeneratedGrass = 200;
    public static float Max_Height_GeneratedTrees = 0.4f;
    public static float Max_Z_Dist_GeneratedTrees = 10f;
    public static int Initial_Calzada_Position { get; set; }

    #endregion

    /// <summary>
    /// PLAYER PROPERTIES
    /// </summary>
    #region PLAYER
    public static int Max_Player_Velocity = 40;
    public static int Min_Player_Velocity = 0;
    public static int Step_Player_Velocity = 1;
    #endregion
}
