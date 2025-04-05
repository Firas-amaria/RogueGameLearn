using Unity.VisualScripting;
using UnityEngine;

public class playerMovement : MonoBehaviour
{

    public float speed =5;
    private Vector2 direction;
    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }
    public void Update()
    {
        TakeInput();
        Move();

    }
    private void Move()
    {
        transform.Translate(direction * speed * Time.deltaTime);
        SetAnimatoeMovement(direction);
    }

    private void TakeInput()
    {
        direction = Vector2.zero;
        if (Input.GetKey(KeyCode.W)) 
        { 
            direction += Vector2.up;
        }
        if (Input.GetKey(KeyCode.A))
        {
            direction += Vector2.left;
        }
        if (Input.GetKey(KeyCode.S))
        {
            direction += Vector2.down;
        }
        if (Input.GetKey(KeyCode.D))
        {
            direction += Vector2.right;
        }
    }

    private void SetAnimatoeMovement(Vector2 direction)
    {
        animator.SetFloat("xDir" ,direction.x);
        animator.SetFloat("yDir", direction.y);
        print(animator.GetFloat("xDir"));
    }
}
