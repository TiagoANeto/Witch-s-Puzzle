using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Interactor : MonoBehaviour
{
    [SerializeField] Transform interationPoint;
    [SerializeField] float interationRadius;
    [SerializeField] LayerMask interactableLayer;
    [SerializeField] private int numberContains;
    private readonly Collider[] colliders = new Collider[5];


    void Update()
    {
        ///numberContains = Physics.CheckSphere(interationPoint.position, interationRadius, colliders, interactableLayer);
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(interationPoint.position, interationRadius);
    }
    
}
