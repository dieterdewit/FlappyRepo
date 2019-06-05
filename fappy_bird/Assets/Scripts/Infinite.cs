using UnityEngine;

public class Infinite : MonoBehaviour {
    public static float scrollingSpeed = 5f;

    // Update is called once per frame
	void Update () {
        transform.Translate(Vector2.left * scrollingSpeed * Time.deltaTime);
        if (transform.position.x < -20.4f)
        {
            if (transform.position.x < -20.4f)
            {
                transform.position = new Vector3(20.4f, transform.position.y, transform.position.z);
            }
        }
    }
}
