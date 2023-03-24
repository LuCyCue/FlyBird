using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdController : MonoBehaviour
{
    public float clickUpY = 0.5f;
    Rigidbody2D rigidbody2d;
    Animator animator;
    float animationTime;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        Debug.Log(animator);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) {
            //up
            Debug.Log("click enter");
            clickAction();
        }
        animationTime = animationTime - Time.deltaTime;
        if (animationTime <= 0) {
            animator.SetBool("isFly", false);
        }
    }

    void clickAction() {
        rigidbody2d.velocity = new Vector2(0, clickUpY);
        animator.SetBool("isFly",true);
        animationTime = 0.5f;
    }

    private void OnCollisionEnter2D(Collision2D other) {
        Debug.Log("Fail");
    }

    private void OnTriggerExit2D(Collider2D other) {
        Debug.Log("Goal");
    }
}
