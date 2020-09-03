
using UnityEngine.UIElements.Experimental;

public class ProjectProperties
{
    /// <summary>
    /// TREES PROPERTIES
    /// </summary>
    #region TREES PROPERTIES
    public static float Initial_Tree_Position = 0f;
    public static float Final_Tree_Position = 500f;
    public static float Initial_Tree_RE_Position = 485f;
    public static float Tree_RE_Position_Penal = -5f;

    public static int Tree_Speed { get; set; }
    #endregion

    /// <summary>
    /// CALZADA PROPERTIES
    /// </summary>
    #region CALZADA PROPERTIES
    public static float Initial_Calzada_Z_Position = 460f;
    public static int Weight_Min = 12;
    public static int Weight_Max = 34;
    public static int Max_Num_GeneratedTrees = 50;
    public static float Max_Height_GeneratedTrees = 2.4f;
    public static float Max_Z_Dist_GeneratedTrees = 10f;
    public static int Initial_Calzada_Position { get; set; }

    #endregion
}
