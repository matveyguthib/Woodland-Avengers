using UnityEngine;

public class Dele : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        int i = 0;

        if (collision.gameObject.CompareTag("Medved"))
        {
            i++;
            if (i == 1)
            {
                Destroy(gameObject);
            }
        }
        if (collision.gameObject.CompareTag("Lisa"))
        {
            i++;
            if (i == 1)
            {
                Destroy(gameObject);
            }
        }
        if (collision.gameObject.CompareTag("Zayats"))
        {
            i++;
            if (i == 1)
            {
                Destroy(gameObject);
            }
        }
        if (collision.gameObject.CompareTag("Volk"))
        {
            i++;
            if (i == 1)
            {
                Destroy(gameObject);
            }
        }
        if (collision.gameObject.CompareTag("Los"))
        {
            i++;
            if (i == 1)
            {
                Destroy(gameObject);
            }
        }
        if (collision.gameObject.CompareTag("Ej"))
        {
            i++;
            if (i == 1)
            {
                Destroy(gameObject);
            }
        }
        if (collision.gameObject.CompareTag("Krot"))
        {
            i++;
            if (i == 1)
            {
                Destroy(gameObject);
            }
        }
        if (collision.gameObject.CompareTag("Bober"))
        {
            i++;
            if (i == 1)
            {
                Destroy(gameObject);
            }
        }
        if (collision.gameObject.CompareTag("Myshi"))
        {
            i++;
            if (i == 1)
            {
                Destroy(gameObject);
            }
        }
        if (collision.gameObject.CompareTag("Belka"))
        {
            i++;
            if (i == 1)
            {
                Destroy(gameObject);
            }
        }
    }
}