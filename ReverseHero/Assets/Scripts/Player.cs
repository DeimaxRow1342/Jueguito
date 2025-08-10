using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public float speed = 5f;


    private Rigidbody2D rb2D;
    private Vector2 movementeInput;

    void Start()
    {
      rb2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
      movementeInput.x = Input.GetAxisRaw("Horizontal");
      movementeInput.y = Input.GetAxisRaw("Vertical");

      movementeInput = movementeInput.normalized;
    }

    private void FixedUpdate()
    {
      rb2D.linearVelocity = movementeInput * speed;
    }
}
