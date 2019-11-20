using UnityEngine;

public class chicken : MonoBehaviour
{
    [Header("速度")][Range(1,100)]
    public int speed = 10;
    [Tooltip("G8雞旋轉速度")][Range(1,100)]
    public float turn = 20.5f;
    public bool mission;
    public string name = "G8雞";
    public int 雞蛋數量 = 5;


}
