using System;
using System.Collections;
using System.Collections.Generic;
using TFG_SP;
using UnityEngine;

namespace NoEyeInTea
{
  
    [RequireComponent(typeof(Collider2D))]
    public class PointInColliderDisplay2D : MonoBehaviour
    {

        [SerializeField] private GameObject _cursor;

        [SerializeField] private Collider2D _collider;

        //private Collider Collider => _collider ??= GetComponent<Collider>();

        public void GetNewPoint()
        {

            if (_collider == null)
            {
                return;
            }

            var newPoint = Vector2.zero;

            newPoint = _collider.GetRandomInternalPoint2D(100);

            if (!float.IsNaN(newPoint.x) && newPoint != Vector2.positiveInfinity)
            {
                _cursor.transform.position = new Vector3(newPoint.x, newPoint.y, _cursor.transform.position.z);
            }

        }

    }
}
