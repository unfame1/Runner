using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    [SerializeField] private float _moveSpeed;
    [SerializeField] private float _stepSize;
    [SerializeField] private float _maxHeight;
    [SerializeField] private float _minHeight;

    private Vector3 _targetPosition;

    private void Start()
    {
        transform.position = new Vector3(transform.position.x, 0, transform.position.z);
        _targetPosition = transform.position;
    }

    private void Update()
    {
        if (transform.position != _targetPosition)
            transform.position = Vector3.MoveTowards(transform.position, _targetPosition, _moveSpeed * Time.deltaTime);
    }

    public void TryMoveUp()
    {
        Debug.Log($"_targetPosition.y is {_targetPosition.y}");
        Debug.Log($"_maxHeight is {_maxHeight}");
        if (_targetPosition.y < _maxHeight)
        {
            Debug.Log("Up works!");
            SetNextPosition(_stepSize);
        }
    }

    public void TryMoveDown()
    {
        if (_targetPosition.y > _minHeight)
        {
            Debug.Log("Down works!");
            SetNextPosition(-_stepSize);
        }
    }

    private void SetNextPosition(float stepsize)
    {
        _targetPosition = new Vector3(_targetPosition.x, _targetPosition.y + stepsize, _targetPosition.z);
    }

}
