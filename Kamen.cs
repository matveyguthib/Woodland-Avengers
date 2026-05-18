using UnityEngine;

public class Delete : MonoBehaviour
{
    private int i = 0;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        

        if (collision.gameObject.CompareTag("Medved"))
        {
            i = i + 3;
            if (i == 3)
            {
                Destroy(gameObject);
            }
        }
        if (collision.gameObject.CompareTag("Lisa"))
        {
            i++;
            if (i == 3)
            {
                Destroy(gameObject);
            }
        }
        if (collision.gameObject.CompareTag("Zayats"))
        {
            i++;
            if (i == 3)
            {
                Destroy(gameObject);
            }
        }
        if (collision.gameObject.CompareTag("Volk"))
        {
            i = i+2;
            if (i == 3)
            {
                Destroy(gameObject);
            }
        }
        if (collision.gameObject.CompareTag("Los"))
        {
            i = i + 3;
            if (i == 3)
            {
                Destroy(gameObject);
            }
        }
        if (collision.gameObject.CompareTag("Ej"))
        {
            i++;
            if (i == 3)
            {
                Destroy(gameObject);
            }
        }
        if (collision.gameObject.CompareTag("Krot"))
        {
            i++;
            if (i == 3)
            {
                Destroy(gameObject);
            }
        }
        if (collision.gameObject.CompareTag("Bober"))
        {
            i++;
            if (i == 3)
            {
                Destroy(gameObject);
            }
        }
        if (collision.gameObject.CompareTag("Myshi"))
        {
            i++;
            if (i == 3)
            {
                Destroy(gameObject);
            }
        }
        if (collision.gameObject.CompareTag("Belka"))
        {
            i++;
            if (i == 3)
            {
                Destroy(gameObject);
            }
        }
    }
}