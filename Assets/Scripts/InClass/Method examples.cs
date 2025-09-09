using UnityEngine;

public class Methodexamples : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Vector2 vec = new Vector2(3, 4);
        Vector2 anotherVec = new Vector2(8, 0);

        float magnitude = GetMagnitude(vec);
        float anotherMagnetude = GetMagnitude(anotherVec);

        print(magnitude);
        print(anotherMagnetude);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   public static float GetMagnitude(Vector2 v)
    {
        return Mathf.Sqrt(Mathf.Pow(v.x, 2) + Mathf.Pow(v.y, 2));
    }
}
