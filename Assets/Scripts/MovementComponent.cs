using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MovementComponent : MonoBehaviour
{
    public event Action OnPositionReached;
    Vector3 initialPosition = Vector3.zero;
    [SerializeField] Light lightToMove = null;
    [SerializeField] float moveSpeed = 1;
    [SerializeField] Vector3 moveDirection = Vector3.zero;
    [SerializeField] bool canMove = true;
    [SerializeField] float maxDistance = 3.1f;
    [SerializeField] float maxDistanceOffset = .8f;

    public bool CanMove
    { get { return canMove; } set { canMove = value; } }

    void Start()
    {
        Init();
        if (!lightToMove) return;
        OnPositionReached += lightToMove.GetComponent<MovementComponent>().SetCanMove;
    }

    void SetCanMove()
    { 
        canMove = true;
        Debug.Log("called SetCanMove");
    }


    void Init()
    {
        initialPosition = transform.position;
    }

   public void Move(GameObject _gameObjectToMove)
    {
        if (canMove && CheckDistanceMoved() <= maxDistance)
        {
            _gameObjectToMove.transform.position += moveDirection * moveSpeed * Time.deltaTime;
        }
        else if (CheckDistanceMoved() > maxDistance && canMove == true )
            canMove = false;
        else if (CheckDistanceMoved() > maxDistance - maxDistanceOffset)
        { 
             OnPositionReached?.Invoke();
            if (!lightToMove) return;
            lightToMove.GetComponent<MovementComponent>().CanMove = true;
        }

    }

    void Update()
    {
        Move(transform.gameObject);
    }

    float CheckDistanceMoved()
    { 
       return Vector3.Distance(initialPosition, transform.position);
    }


}
