using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class LabirintSnake : MonoBehaviour
{
	[SerializeField] private List<Transform> _tails;
	[SerializeField] private float _bonesDistance;
	[Range(0, 30), SerializeField] private float _moveSpeed;

	public UnityEvent OnEat;

	public void FixedUpdate()
	{
		MoveHead(_moveSpeed);
		MoveTail();
	}

	private void MoveHead(float speed)
    {
		transform.position = transform.position + transform.forward * speed * Time.deltaTime;
    }

	private void MoveTail()
    {
		float sqrDistance = Mathf.Sqrt(_bonesDistance);
		Vector3 previvousPosition = transform.position;

		foreach (var bone in _tails)
        {
			if ((bone.position - previvousPosition).sqrMagnitude > sqrDistance)
            {
				Vector3 currentBonePosition = bone.position;
				bone.position = previvousPosition;
				previvousPosition = currentBonePosition;
            }
			else
            {
				break;
            }
        }
    }

	private void OnTriggerEnter(Collider other)
    {
		if(other.TryGetComponent(out Eat eat))
        {
		OnEat.Invoke();// test
		Destroy(other.gameObject);

		//if (OnEat != null)
		//	{
		//		OnEat.Invoke();
		//	}	
        }
    }
}