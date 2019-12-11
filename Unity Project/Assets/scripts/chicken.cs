using UnityEngine;

public class chicken : MonoBehaviour
{
    #region 欄位區域
    [Header("速度")][Range(1,2000)]
    public int speed = 10;
    [Tooltip("G8雞旋轉速度")][Range(1,200)]
    public float turn = 20.5f;
    public bool mission;
    public string name = "G8雞";
    public int 雞蛋數量 = 5;
    #endregion

    public Transform tran;
    public Rigidbody rig;
    public Animator ani;

    private void Update()
    {
        Turn();
        Run();
        Bark();
        Catch();
    }

    #region 方法區域
    /// <summary>
    /// 跑步
    /// </summary>
    private void Run()
    {
        float v = Input.GetAxis("Vertical");
        rig.AddForce(tran.forward * speed * v * Time.deltaTime);
    }
    /// <summary>
    /// 旋轉
    /// </summary>
    private void Turn()
    {
        float h = Input.GetAxis("Horizontal");
        tran.Rotate(0, turn * h * Time.deltaTime, 0);
    }
    /// <summary>
    /// 亂叫
    /// </summary>
    private void Bark()
    {
        if (Input.GetKeyDown("space"))
        {
            ani.SetTrigger("拍翅膀觸發");
        }
    }
    /// <summary>
    /// 撿東西
    /// </summary>
    private void Catch()
    {
        if (Input.GetMouseButton(0))
        {
            ani.SetTrigger("撿東西觸發");
        }
    }
    /// <summary>
    /// 檢視任務
    /// </summary>
    private void Task()
    {

    }
    #endregion
}
