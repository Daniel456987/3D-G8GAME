using UnityEngine;

public class Learnif : MonoBehaviour
{
    public bool openDoor;

    public int score;

    [Header("連擊次數"),Range(1,200)]
    public int combo;
    private void Start()
    {
        if (true)
        {
            print("測試");
        }
    }

    private void Update()
    {
        if (openDoor)
        {
            print("開門");
        }
        else
        {
            print("關門");
        }

        if (score >= 60)
        {
            print("及格");
        }
        else if (score >= 50)
        {
            print("可以補考");
        }
        else if (score >=40)
        {
            print("可以付錢補考");
        }

        if (combo >= 150)
        {
            print("攻擊10倍");
        }
        else if (combo >= 100)
        {
            print("攻擊5倍");
        }
        else if (combo >= 50)
        {
            print("攻擊2倍");
        }
    }
}
