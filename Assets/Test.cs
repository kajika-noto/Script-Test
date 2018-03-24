using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//クラス作成
public class Boss
{
    private int hp = 100;
    private int power = 25;
    private int mp = 53;

    public void Attack()
    {
        Debug.Log(this.power + "のダメージを与えた");
    }
    public void Defence(int damage)
    {
        Debug.Log(damage + "のダメージを受けた");
        this.hp -= damage;
    }
    public void Magic(int spend)
    {
        if (spend < mp)
        {
            Debug.Log("魔法攻撃をした。残りMPは" + mp + "。");
            this.mp -= spend;
        } else
        {
            Debug.Log("MPが足りないため魔法が使えない！");
        }
    }
}

public class Test : MonoBehaviour {


	// Use this for initialization
	void Start () {
        
        //課題
        int[] array = { 11, 22, 33, 44, 55 };

        for (int i = 0; i < array.Length; i++)
        {
            Debug.Log(array[i]);
        }

        for (int ii = (array.Length - 1); ii >= 0; ii--)
        {
            Debug.Log(array[ii]);
        }


        //発展課題
        Boss lastboss = new Boss();

        lastboss.Attack();
        lastboss.Defence(3);

        for (int i = 0; i < 11; i++)
        {
            lastboss.Magic(5);
        }
    }
     
	
	// Update is called once per frame
	void Update () {
		
	}
}
