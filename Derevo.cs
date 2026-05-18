using UnityEngine;

public class Deleting : MonoBehaviour
{
    private int i = 0;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        

        if (collision.gameObject.CompareTag("Medved"))
        {
            i++;
            if (i == 2)
            {
                Destroy(gameObject);
            }
        }
        if (collision.gameObject.CompareTag("Lisa"))
        {
            i = i++;
            if (i == 2)
            {
                Destroy(gameObject);
            }
        }
        if (collision.gameObject.CompareTag("Zayats"))
        {
            i = i+2;
            if (i == 2)
            {
                Destroy(gameObject);
            }
        }
        if (collision.gameObject.CompareTag("Volk"))
        {
            i++;
            if (i == 2)
            {
                Destroy(gameObject);
            }
        }
        if (collision.gameObject.CompareTag("Los"))
        {
            i = i + 2;
            if (i == 2)
            {
                Destroy(gameObject);
            }
        }
        if (collision.gameObject.CompareTag("Ej"))
        {
            i++;
            if (i == 2)
            {
                Destroy(gameObject);
            }
        }
        if (collision.gameObject.CompareTag("Krot"))
        {
            i++;
            if (i == 2)
            {
                Destroy(gameObject);
            }
        }
        if (collision.gameObject.CompareTag("Bober"))
        {
            i = i + 2;
            if (i == 2)
            {
                Destroy(gameObject);
            }
        }
        if (collision.gameObject.CompareTag("Myshi"))
        {
            i = i +2;
            if (i == 2)
            {
                Destroy(gameObject);
            }
        }
        if (collision.gameObject.CompareTag("Belka"))
        {
            i = i+2;
            if (i == 2)
            {
                Destroy(gameObject);
            }
        }
    }
}
//public class MoveRightOnCollision2 : MonoBehaviour
//{
//    [SerializeField] private float moveDistance = 100f;

//    private void OnCollisionEnter2D(Collision2D collision)
//    {

//        if (collision.gameObject.CompareTag("Myshi"))
//        {
//            transform.position = new Vector3(transform.position.x + moveDistance, transform.position.y, transform.position.z);
//        }
//    }
//}