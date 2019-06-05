using UnityEngine;

public class Fappy : MonoBehaviour {

    public float jumpForce = 180f;
    private Rigidbody2D rb;

	void Start () {
        rb = GetComponent<Rigidbody2D>();
	}

    void Update() {
        if (GameController.instancia.gameOver == false)
        {
            if (Input.GetButtonDown("Jump")) {
                rb.velocity = Vector2.zero;
                rb.AddForce(Vector2.up * jumpForce);
            }
        }
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameController.instancia.gameOver = true;
        Infinite.scrollingSpeed = 0;
        Pipe.scrollingSpeed = 0;
        PipeOrama.spawnTime = 10000000;
    }
}
