using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{
    private int hp = 100;           // 体力
    private int power = 25;         // 攻撃力
    private int mp = 53;            // マジックポイント
    public void Attack()
    {
        Debug.Log(this.power + "のダメージを与えた");
    }
    public void Defence(int damage)
    {
        Debug.Log(damage + "のダメージを受けた");
        this.hp -= damage;
    }
    public void magic1()
    {
        if (mp >= 5)
        {
            mp -= 5;
            Debug.Log("魔法攻撃をした。残りMPは" + this.mp + "。");
        }
        else
        {
            Debug.Log("MPが足りないため、魔法が使えない。");
        }
    }
}

public class Test : MonoBehaviour
{
    private int[] array = { 10, 20, 30, 40, 50 };
    void Start()
    {
        for (int i = 0; i < array.Length; i++)
        {
            Debug.Log(array[i]);
        }
        for (int i = 4; i >= 0; i--)
        {
            Debug.Log(array[i]);
        }
        Boss lastboss = new Boss();
        lastboss.Attack();
        lastboss.Defence(3);
        for(int iii=0;iii<11;iii++)
        lastboss.magic1();
    }
    void Update()
    {

    }
}