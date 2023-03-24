using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeManager : MonoBehaviour
{
    public GameObject pipePrefab;
    public float minCreateTime = 1.0f;
    public float maxCreateTime = 2.0f;
    public float minRandomY = -1.0f;
    public float maxRandomY = 1.0f;
    public float timer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer = timer - Time.deltaTime;
        if (timer <= 0) {
            createPipe();
            timer = Random.Range(minCreateTime, maxCreateTime);
        }
    }

    void createPipe() {
        float y = Random.Range(minRandomY, maxRandomY);
        Vector3 positon = pipePrefab.transform.position;
        Vector3 targetPosition = new Vector3(positon.x+2, positon.y+y, positon.z);
        GameObject pipe = Instantiate(pipePrefab, targetPosition, Quaternion.identity);
    }
}
