using UnityEngine;

public class CubeController : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 2f;
    [SerializeField] private float rayDistance = 1.5f;
    [SerializeField] private LayerMask obstacleLayer;
    private Animator animator;

    private bool isClicked = false;
    private bool shouldMove = false;

    void Awake()
    {
        animator = GetComponent<Animator>();
    }
    void OnMouseDown()
    {
        if (isClicked) return;

        if (IsFrontBlocked())
        {
            animator.SetTrigger("Blocked");
            return;
        }
        else
        {
            shouldMove = true;
            isClicked = true;
            animator.SetTrigger("FirstClick");
        }

    }

    void Update()
    {
        if (shouldMove)
        {
            transform.Translate(Vector3.right * moveSpeed * Time.deltaTime, Space.Self);
        }
    }

    private bool IsFrontBlocked()
    {
        Vector3 origin = transform.position;
        Vector3 direction = transform.right;
        Ray ray = new Ray(origin, direction);

        return Physics.Raycast(ray, rayDistance, obstacleLayer);
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Vector3 origin = transform.position;
        Gizmos.DrawRay(origin, transform.right * rayDistance);
    }
}
