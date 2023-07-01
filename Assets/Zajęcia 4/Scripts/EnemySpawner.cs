using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public EnemyScript enemy;
    public Transform enemiesContainer;

    public Transform player;

    public float distance = 5f;
    public int maxCount = 10;

    public int currentCount = 0;

    private void Start()
    {
        InvokeRepeating(nameof(CreateEnemy), 0f, 0.3f);
    }

    public void CreateEnemy()
    {
        if (currentCount >= maxCount) return;
        
        EnemyScript enemyScript = Instantiate(enemy, GetPosition(), Quaternion.identity, enemiesContainer);
        enemyScript.target = player;
        enemyScript.spawner = this;
        enemyScript.gameObject.SetActive(true);
        currentCount++;
    }

    Vector3 GetPosition()
    {
        Vector3 ret;

        float x;
        float y;
        do
        {
            x = Random.Range(-1f, 1f);
            y = Random.Range(-1f, 1f);
        } while (x == 0 && y == 0);
        
        ret = new Vector3(x, y, 0);
        ret.Normalize();

        return ret * distance;
    }
}
