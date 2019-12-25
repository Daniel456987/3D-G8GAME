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

    [Header("檢視物品位置")]
    public Rigidbody rigCatch;

    
    private void OnTriggerStay(Collider other)
    {
        print(other.name);

        if(other.name == "雞腿" && ani.GetCurrentAnimatorStateInfo(0).IsName("Eat"))
        {
            Physics.IgnoreCollision(other,GetComponent<Collider>());
            
            other.GetComponent<HingeJoint>().connectedBody = rigCatch;
        }

        if (other.name == "感應區" && ani.GetCurrentAnimatorStateInfo(0).IsName("Eat"))
        {
            GameObject.Find("雞腿").GetComponent<HingeJoint>().connectedBody = null;
        }
    }

    public Transform tran;
    public Rigidbody rig;
    public Animator ani;
    public AudioSource aud;

    public AudioClip soundBark;

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
        if (ani.GetCurrentAnimatorStateInfo(0).IsName("Eat")) return;
        float v = Input.GetAxis("Vertical");
        rig.AddForce(tran.forward * speed * v * Time.deltaTime);

        ani.SetBool("走路開關", v != 0);
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

            aud.PlayOneShot(soundBark, 0.6f);
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
