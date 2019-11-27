using UnityEngine;

public class chicken : MonoBehaviour
{
    #region 欄位區域
    [Header("速度")][Range(1,100)]
    public int speed = 10;
    [Tooltip("G8雞旋轉速度")][Range(1,100)]
    public float turn = 20.5f;
    public bool mission;
    public string name = "G8雞";
    public int 雞蛋數量 = 5;
    #endregion

    #region 方法區域
    /// <summary>
    /// 跑步
    /// </summary>
    private void Run()
    {

    }
    /// <summary>
    /// 旋轉
    /// </summary>
    private void Turn()
    {

    }
    /// <summary>
    /// 亂叫
    /// </summary>
    private void Bark()
    {

    }
    /// <summary>
    /// 撿東西
    /// </summary>
    private void Catch()
    {

    }
    /// <summary>
    /// 檢視任務
    /// </summary>
    private void Task()
    {

    }
    #endregion
}
