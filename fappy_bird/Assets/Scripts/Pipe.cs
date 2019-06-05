using UnityEngine;

public class Pipe : MonoBehaviour {

    public static float scrollingSpeed = 2f;

    void Update () {
        transform.Translate(Vector3.left * Time.deltaTime * scrollingSpeed );
        if (transform.position.x < -8)
        {
            Destroy(gameObject);
        }
    }
}
