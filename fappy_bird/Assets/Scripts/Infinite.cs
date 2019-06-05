using UnityEngine;

public class Infinite : MonoBehaviour {
    public static float scrollingSpeed = 5f;

    // Update is called once per frame
	void Update () {
        transform.Translate(Vector2.left * scrollingSpeed * Time.deltaTime);
        if (transform.position.x < -20f)
        {
            if (transform.position.x < -20f)
            {
                transform.position = new Vector3(20f, transform.position.y, transform.position.z);
            }
        }
    }
}
