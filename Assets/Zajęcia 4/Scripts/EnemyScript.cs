using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class EnemyScript : MonoBehaviour
{
    public float speed;
    
    public Transform target;
    public EnemySpawner spawner;
    public Button button;

    private TMP_Text text;
    private TextMeshProUGUI text2;

    private void Start()
    {
        button.onClick.AddListener(Test);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 distance = target.position - transform.position;
        if (distance.magnitude < 0.5f)
        {
            spawner.currentCount--;
            Destroy(gameObject);
        }

        transform.Translate(distance.normalized * Time.deltaTime * speed);
    }

    private void Test()
    {

        button.onClick.RemoveListener(Test);
    }
}
