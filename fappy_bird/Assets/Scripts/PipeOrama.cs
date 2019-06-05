using UnityEngine;

public class PipeOrama : MonoBehaviour {
    public GameObject column;
    public static float spawnTime = 4f;
    public static float elapsedTime = 0f;

    // Update is called once per frame
	void Update () {
        if (elapsedTime < spawnTime)
        {
            elapsedTime += Time.deltaTime;

        }
        else
        {
            float random = Random.Range(-2f, 2f);
            Instantiate(column, new Vector3(8, random, 0),Quaternion.identity);
            elapsedTime = 0;
        }
	}
}
