using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundController : MonoBehaviour
{
    public float speed;
    public float limit_x;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 position = gameObject.transform.position;
        position.x = (-speed * Time.deltaTime) + position.x;
        if (position.x <= -limit_x) {
            position.x = limit_x-1;
        }
        gameObject.transform.position = position;
    }
}
