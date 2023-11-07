using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    public Slider healthSlider;
    public GameObject Player;
    private NavMeshAgent agent;
    private Transform targe;

    // Start is called before the first frame update
    void Start()
    {
      agent = GetComponent<NavMeshAgent>();
        targe = Player.transform;
    }

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(targe.position);
        if ((Player.transform.position - agent.transform.position).sqrMagnitude < 10)
        {
            healthSlider.value = healthSlider.value - 1;
        }
    }
}
