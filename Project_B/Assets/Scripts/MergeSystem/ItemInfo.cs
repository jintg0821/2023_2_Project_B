using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemInfo : MonoBehaviour
{ // ���� ���� ���� ���� ������ �ִ� Ŭ����
    public int slotId;      // ���� ��ȣ (SLOT Ŭ���� ���� ��)
    public int itemId;      // ������ ��ȣ

    public void InitDummy(int slotId, int itemId)
    { // �μ��� ���� ������ class �ʿ� �Է�
        this.slotId = slotId;
        this.itemId = itemId;
    }
}
