using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class NewBehaviourScript : MonoBehaviour
{

    string Name = "田中";
    int hp = 100;
    float speed = 158.3f;
    bool flag1 = true;
    bool flag2 = false;

    public enum TYPE
    {
        STOP,
        RIGHT,
        LEFT
    }

    TYPE type = TYPE.STOP;

    void Start()
    {
        PlayerModel player = new PlayerModel();
        player.SayName();
        player.Hp = 1000;
        // プロパティにアクセス
        Debug.Log(player.Hp);

        if (type == TYPE.STOP)
        {
            Debug.Log(type);
        }

        string say = "Hello world";
        Debug.Log(say);

        const string sayConst = "Hello world2";
        Debug.Log(sayConst);
        Debug.Log(Name);
        Debug.Log(hp);
        Debug.Log(speed);
        Debug.Log(flag1);
        Debug.Log(!flag2);

        int a = 10;
        int b = 2;
        Debug.Log(a + b);
        Debug.Log(a - b);
        Debug.Log(a * b);
        Debug.Log(a / b);
        Debug.Log(a % b);
        a += 5;
        a++;
        Debug.Log(a);
        Debug.Log(flag1 && flag2);
        Debug.Log(flag1 || flag2);

        if (a > 5)
        {
            Debug.Log("処理A");
        }
        else if (a > 100)
        {
            Debug.Log("処理B");
        }
        else
        {
            Debug.Log("処理C");
        }

        if (hp % 3 == 1)
        {
            Debug.Log("A");
        }
        else if (hp % 3 == 2)
        {
            Debug.Log("B");
        }
        else if (hp % 3 == 0)
        {
            Debug.Log("C");
        }

        string characterType = "ああああ";

        switch (characterType)
        {
            case "Player":
            case "Frends":
                Debug.Log("味方だよ");
                break;
            case "Enemy":
                Debug.Log("敵だよ");
                break;
            default:
                Debug.Log("その他");
                break;
        }

        int x = 0;
        while (x < 5)
        {
            Debug.Log(x);
            x++;
        }

        for (int i = 0; i < 5; i++)
        {
            if (i == 3)
            {
                continue;
            }
            Debug.Log(i);
        }

        int[] xList = new int[3];
        xList[0] = 0;
        xList[1] = 2;
        xList[2] = -3;

        int[] yList = new int[3] { 0, 1, -4 };

        Debug.Log(xList[0]);
        Debug.Log(xList[1]);
        Debug.Log(xList[2]);
        Debug.Log(yList[0]);
        Debug.Log(yList[1]);
        Debug.Log(yList[2]);

        Debug.Log(xList.Length);

        for (int i = 0; i < xList.Length; i++)
        {
            Debug.Log(xList[i]);
        }

        List<int> numbers = new List<int>() { -1, 21, 45 };
        Debug.Log(numbers[0]);
        Debug.Log(numbers[1]);
        Debug.Log(numbers[2]);
        numbers[0] = 0;
        Debug.Log(numbers[0]);

        numbers.Add(100);
        Debug.Log(numbers[3]);

        Debug.Log(numbers.Count);

        numbers.RemoveAt(1);
        numbers.Remove(21);
        Debug.Log(numbers.Count);

        List<string> nameList = new List<string>() { "山田", "太郎", "佐藤" };
        foreach (string Name in nameList)
        {
            Debug.Log(Name);
        }

        string name1 = SampleNameFunction("田中");
        string name2 = SampleNameFunction("佐藤");
        Debug.Log(name1);
        Debug.Log(name2);
        Debug.Log(SampleAddfunction(10, 2));

        Debug.Log(GetSumNumber(1, 5));
        GetavgNumber(1, 5);

        GetMaxValue();
    }

    void Update()
    {

    }

    string SampleNameFunction(string sampleName)
    {
        Debug.Log(sampleName);
        return sampleName + "さん";
    }

    int SampleAddfunction(int a, int b)
    {
        return a + b;
    }

    int GetSumNumber(int n, int m)
    {
        int sum = 0;
        for (int i = n; i < m + 1; i++)
        {
            sum += i;
        }
        return sum;
    }

    void GetavgNumber(int n, int m)
    {
        List<int> list = new List<int>();
        for (int i = n; i < m + 1; i++)
        {
            list.Add(i);
        }
        double avg = list.Average();
        Debug.Log(avg);
    }

    void GetMaxValue()
    {
        int[] numberList = new int[4] { 2, -1, 11, 123 };
        Debug.Log(numberList.Max());

        /*
        Max関数を使わない場合
        int GetMaxValue(int[] numberList)
        int maxValue = numberList[0];
        for(int i = 0;i < numberList.Length; i++)
        {
            if(maxValue < numberList[i])
            {
                maxValue = numberList[i]; 
            }
        }
        return maxValue;
        */
    }

}
