using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour
{
    public float range = 3.0f;          // Ÿ�� ��Ÿ�
    public float fireRate = 1.0f;       // Ÿ�� �߻� ����
    public LayerMask IsEnemy;           // ���̾� �ý������� ����

    public Collider[] colliderInRange;  // ��Ÿ��� ������ Collider �迭

    public List<EnemyController> enemiesInRange = new List<EnemyController>();  // ��Ÿ� �ȿ� �ִ� Enemy ������Ʈ List

    public float checkCounter;          // �ð� üũ�� float
    public float checkTime = 0.2f;      // 0.2�ʸ��� ����

    public bool enemiesUpdate;

    // Start is called before the first frame update
    void Start()
    {
        checkCounter = checkTime;
    }

    // Update is called once per frame
    void Update()
    {
        enemiesUpdate = false;

        checkCounter -= Time.deltaTime;             // 0.2 -> 0�ʰ� �� ������ �ð��� ����

        if(checkCounter <= 0)                       // 0�� ���ϰ� �Ǿ��� ��
        {
            checkCounter = checkTime;               // 0.2�ʷ� �ٽ� ����

            colliderInRange = Physics.OverlapSphere(transform.position, range, IsEnemy);    // �ڽ��� ��ġ, ������, ���̰��� ���ؼ� Collider ����

            enemiesInRange.Clear();         // List �ʱ�ȭ

            foreach (Collider col in colliderInRange)
            {
                enemiesInRange.Add(col.GetComponent<EnemyController>());
            }

            enemiesUpdate = true;
        }
    }
}
