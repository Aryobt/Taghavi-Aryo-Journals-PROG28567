using UnityEngine;

public class StaticMethods : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Vector2 vec = new Vector2(6, 18);

        float magnitude = Methodexamples.GetMagnitude(vec);

        print($"This is inside StaticMethods: {magnitude} ");

    }

    public static void DrawRectangle(Vector2 pos, Vector2 size, Color color)
    {
        float halfWidth = size.x /2;
        float halfHeight = size.y /2;

        Vector2 topLeft = new Vector2(pos.x - halfWidth, pos.y + halfHeight);
        Vector2 topRight = topLeft + Vector2.left * size.x;
        Vector2 bottomRight = new Vector2(pos.x + halfWidth, pos.y - halfHeight);
        Vector2 bottoLeft = bottomRight + Vector2.left * size.y;
      

        Debug.DrawLine(topLeft, topLeft + Vector2.right * size.x);
        Debug.DrawLine(topLeft + Vector2.up * size.x, bottomRight);
        //Debug.DrawLine();
        //Debug.DrawLine();
    }

}
