using UnityEngine;
using UnityEngine.AI;

public class ZombieFollow : MonoBehaviour
{
    public Transform player; // Sleep het speler-object hierheen in de inspector
    public float detectionRange = 15f; // Afstand waarop de zombie de speler detecteert
    public float stopDistance = 2f; // Afstand waarop de zombie stopt met volgen
    public float walkSpeed = 1.5f; // De snelheid waarmee de zombie loopt

    private NavMeshAgent agent;
    private Animator animator;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();
        agent.speed = walkSpeed; // Stel de snelheid van de zombie in
    }

    void Update()
    {
        float distanceToPlayer = Vector3.Distance(transform.position, player.position);

        if (distanceToPlayer <= detectionRange && distanceToPlayer > stopDistance)
        {
            // Zombie begint te lopen richting de speler
            agent.SetDestination(player.position);
            animator.SetBool("isWalking", true);
        }
        else
        {
            // Zombie stopt met lopen
            agent.ResetPath();
            animator.SetBool("isWalking", false);
        }
    }
}
