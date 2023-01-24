using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Paeva_MY_1_4
{
    public class Script_1_4 : MonoBehaviour
    {
        [SerializeField] private PathfTypes _pathf1;
        [SerializeField] private PathfTypes _pathf2;
        [SerializeField] private Color _mycolor;
        [SerializeField, Range(0, 10)] private float _speed = 3;
        [SerializeField, Range(0, 10)] private float _stepSize = 5;

        private Coroutine _motionRoutine;
        private Vector3 _startPosition;
        private List<GameObject> _pointShapes = new();

        private void Start()
        {
            _startPosition = transform.position;
        }

        private void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                StopMotion();
                StartMotion(_pathf1);
            }
            if (Input.GetMouseButtonDown(1))
            {
                StopMotion();
                StartMotion(_pathf2);
            }
        }

        private void StartMotion(PathfTypes pathf)
        {
            switch (pathf)
            {
                case PathfTypes.Square:
                    _motionRoutine = StartCoroutine(ShapeMotion(90));
                    break;

                case PathfTypes.Triangle:
                    _motionRoutine = StartCoroutine(ShapeMotion(120));
                    break;

                case PathfTypes.Hexagon:
                    _motionRoutine = StartCoroutine(ShapeMotion(60));
                    break;

                case PathfTypes.Star:
                    _motionRoutine = StartCoroutine(StarMotion());
                    break;
            }
        }

        private IEnumerator MotionForward()
        {
            Vector3 targetPosition = transform.position + transform.forward * _stepSize;

            while (transform.position != targetPosition)
            {
                transform.position = Vector3.MoveTowards(transform.position, targetPosition, _speed * Time.deltaTime);
                yield return null;
            }

            yield break;
        }

        private IEnumerator Rotation(float angle)
        {
            transform.Rotate(Vector3.up, angle);
            yield break;
        }

        private IEnumerator ShapeMotion(float rotationAngle)
        {
            do
            {
                yield return MotionForward();
                AddPointShape();
                yield return Rotation(rotationAngle);
            }
            while (StopWhen());
        }

        private IEnumerator StarMotion()
        {
            do
            {
                yield return MotionForward();
                AddPointShape();
                yield return Rotation(-72);
                yield return MotionForward();
                AddPointShape();
                yield return Rotation(144);
            }
            while (StopWhen());
        }

        private bool StopWhen()
        {
            return true;
            //return transform.position != _startPosition
        }

        private void StopMotion()
        {
            if (_motionRoutine!= null)
            {
                StopCoroutine(_motionRoutine);
            }
            transform.position = _startPosition;
            transform.rotation = Quaternion.identity;
            RemoveAllPointShapes();
        }

        private void AddPointShape()
        {
            float shapeSize = 0.3f;
            GameObject createdShape = GameObject.CreatePrimitive(PrimitiveType.Cube);
            createdShape.transform.localScale = Vector3.one * shapeSize;
            createdShape.transform.position = transform.position;
            createdShape.GetComponent<Renderer>().material.color = _mycolor;
            _pointShapes.Add(createdShape);
        }

        private void RemoveAllPointShapes()
        {
            _pointShapes.ForEach(shape => Destroy(shape));
            _pointShapes.Clear();
        }
    }

    public enum PathfTypes
    {
        Square,
        Triangle,
        Hexagon,
        Star
    }
}
