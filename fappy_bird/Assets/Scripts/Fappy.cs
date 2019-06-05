using UnityEngine;

public class Fappy : MonoBehaviour
{

    public delegate void PlayerDelagate();
    public static event PlayerDelagate OnPlayerScored;

    public float jumpForce = 180f;
    public float tilt = 5;
    private Rigidbody2D rb;

    private Quaternion downRotation;
    private Quaternion forwardRotation;

    void Start () {
        rb = GetComponent<Rigidbody2D>();
        downRotation = Quaternion.Euler(0, 0, -90);
        forwardRotation = Quaternion.Euler(0, 0, 35);
    }

    void Update() 
    {
        if (GameController.instance.gameOver == false)
        {
            if (Input.GetButtonDown("Jump"))
            {
                transform.rotation = forwardRotation;
                rb.velocity = Vector2.zero;
                rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Force);
            }
            transform.rotation = Quaternion.Lerp(transform.rotation, downRotation, tilt * Time.deltaTime );
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "OneMoreFap")
        {
            OnPlayerScored();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "DickOnScreen")
        {
            GameController.instance.gameOver = true;
            Infinite.scrollingSpeed = 0;
            Pipe.scrollingSpeed = 0;
            PipeOrama.spawnTime = 1000000;
        }
        
    }
}
