using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*

Ŭ���� class
��ü�� ���� ���踦 ���� ����� ���� Ʋ
    class Ŭ������
     {
        �ʵ�(field) : Ŭ���� ���ο��� ������� ���� ��ü�� �Ӽ��� ǥ���ϴ� �뵵
        - ����ü�� �����

        �޼ҵ�(method) : Ŭ���� ���ο��� ������� �Լ�, ��ü�� ����, ����� ǥ���ϴ� �뵵�� ����մϴ�.
     }
*/
[Serializable]  //����Ƽ���� Ŭ������ ���� ������ �ν����ͷκ��� Ȯ���� �� �ְ� �ϴ� ���
public class Player
//monobehavier�� ���⶧���� ���� class�� ���忡 ��ġ�� ������Ʈ�� ���� ���� �� �� ����.
{
    public int hp;
    public int max_hp;
    public string name;
    public Sprite image; //UI���� �̹����� �����ٶ� (2d�̹��� ����)

    public void Dance()
    {
        Debug.Log($"{name}�� ���� �߰� �ֽ��ϴ�.");
    }
    public void Heal()
    {
        if (hp >= max_hp)
        {
            Debug.Log("ü���� �̹� �������ֽ��ϴ�.");
            return; //void �Լ����� return �� ����ϸ� �Լ��� ���Ḧ �ǹ��մϴ�.
        }
        hp += 10;
        Debug.Log($"ü���� 10 ȸ���մϴ�. ���� ü�� {hp} / {max_hp}");
    }
}