using UnityEngine;

public class Lisaa : MonoBehaviour
{
    private int r = 0;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Block"))
        {
            r++;

            Destroy(collision.gameObject);

            if (r == 3)
            {
                Destroy(gameObject);
            }
        }
    }
}