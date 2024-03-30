using UnityEngine;

public class AttackAndMovement : MonoBehaviour
{
    public GameObject pointA;
    public GameObject pointB;
    private Rigidbody2D rb;
    private Transform currentPoint;
    public float speed;
    private Animator anim;
    private bool isAttacking = false;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        currentPoint = pointB.transform;
        anim.SetBool("isRunning", true);
    }

    void Update()
    {
        if (!isAttacking)
        {
            MoveBetweenPoints();
        }
    }

    void MoveBetweenPoints()
    {
        Vector2 point = currentPoint.position - transform.position;
        rb.velocity = point.normalized * speed;

        if (Vector2.Distance(transform.position, currentPoint.position) < 0.5f)
        {
            ChangeDirection();
        }
    }

    void ChangeDirection()
    {
        if (currentPoint == pointA.transform)
        {
            Flip();
            currentPoint = pointB.transform;
        }
        else
        {
            Flip();
            currentPoint = pointA.transform;
        }
    }

    void Flip()
    {
        Vector3 localScale = transform.localScale;
        localScale.x *= -1;
        transform.localScale = localScale;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            isAttacking = true;
            anim.SetBool("isRunning", false);
            // Aggiungi qui il codice per l'attacco al giocatore
            // Ad esempio, puoi chiamare una funzione per gestire l'attacco del nemico al giocatore
            AttackPlayer();
        }
    }

    void AttackPlayer()
    {
        // Qui implementa la logica per l'attacco al giocatore
        Debug.Log("Attacco al giocatore!");
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            isAttacking = false;
            anim.SetBool("isRunning", true);
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(pointA.transform.position, 0.5f);
        Gizmos.DrawWireSphere(pointB.transform.position, 0.5f);
        Gizmos.DrawLine(pointA.transform.position, pointB.transform.position);
    }
}
