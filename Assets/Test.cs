using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{
    private int hp = 100;           // �̗�
    private int power = 25;         // �U����
    private int mp = 53;            // �}�W�b�N�|�C���g
    public void Attack()
    {
        Debug.Log(this.power + "�̃_���[�W��^����");
    }
    public void Defence(int damage)
    {
        Debug.Log(damage + "�̃_���[�W���󂯂�");
        this.hp -= damage;
    }
    public void magic1()
    {
        if (mp >= 5)
        {
            mp -= 5;
            Debug.Log("���@�U���������B�c��MP��" + this.mp + "�B");
        }
        else
        {
            Debug.Log("MP������Ȃ����߁A���@���g���Ȃ��B");
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