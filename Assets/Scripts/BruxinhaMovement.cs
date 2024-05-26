using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class BruxinhaMovement : MonoBehaviour {
    public float arriveDistance = 0.25f;
    [SerializeField] NavMeshAgent agent;

    void Update() {
        if (Input.GetMouseButtonDown(0) || Input.GetMouseButtonDown(1)) {
            Vector3 mousePosition = GetMousePosition();

            if (mousePosition != Vector3.zero) {
                SetTarget(mousePosition);
            }
        }
    }

    public void SetTarget(Vector3 target) {
        agent.SetDestination(target);
    }

    Vector3 GetMousePosition() {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit)) {
            return hit.point;
        }
        return Vector3.zero;
    }
}
