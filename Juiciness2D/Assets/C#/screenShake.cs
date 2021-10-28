using UnityEngine;

public class screenShake : MonoBehaviour
{
    Enemy enemy;
    public Vector2 frequency; //Kraften av skakningen. - Daniel
    public Vector2 amplitude; //Hur mycket det ska skakas. - Daniel
    Vector2 time = Vector2.zero; //Hur mycket tid som har gått. - Daniel
    static bool shouldShake; //En bool för ifall skärmen ska skaka eller inte. - Daniel
   public static float shakeTime; //Hur länge det ska skaka. - Daniel
    Vector3 startPos;
    // Start is called before the first frame update
    void Start()
    {
        shouldShake = false;
        startPos = transform.position; //Sätter startPos till kamerans startposition. - Daniel
    }

    // Update is called once per frame
    void Update()
    {
        if (shakeTime > 0)
        {
            Vector3 localPos = transform.position; //localPos blir kamerans position. - Daniel
            time.x += Time.time * frequency.x;
            time.y += Time.time * frequency.y;
            localPos.x = Mathf.Sin(time.x) * amplitude.x;

            transform.position = localPos;
            shakeTime -= Time.deltaTime;
        }
        else
        {
            transform.position = startPos;
        }
    }
}
