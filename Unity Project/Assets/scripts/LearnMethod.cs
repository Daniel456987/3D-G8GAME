using UnityEngine;

public class LearnMethod : MonoBehaviour
{
    private void Drive(int speed)
    {
        print("開車，時速：200");
        print("音效~");
    }

    public void Shoot(int count, float speed, string prop = "無",string direction = "前方")
    {
        print("弓箭數量：" + count);
        print("弓箭速度：" + speed);
        print("弓箭屬性：" + prop);
        print("弓箭方向：" + direction);
    }

    private void Start()
    {
        print("哈囉，沃德");

        Drive(200);
        Drive(300);
        Drive(400);

        Shoot(1, 1.5f);
        Shoot(10, 10.5f, "火屬性");
        Shoot(3, 2, direction: "前後方");
    }
}
