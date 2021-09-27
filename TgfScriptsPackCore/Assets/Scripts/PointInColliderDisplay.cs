using System;
using System.Collections;
using System.Collections.Generic;
using TFG_SP;
using UnityEngine;

namespace NoEyeInTea
{
  
    [RequireComponent(typeof(Collider))]
    public class PointInColliderDisplay : MonoBehaviour
    {

        [SerializeField] private GameObject _cursor;

        [SerializeField] private Collider _collider;

        //private Collider Collider => _collider ??= GetComponent<Collider>();

        public void GetNewPoint()
        {

            if (_collider == null)
            {
                return;
            }

            var newPoint = Vector3.zero;

            newPoint = _collider.GetRandomInternalPoint3D(100);

            if (!float.IsNaN(newPoint.x) && newPoint != Vector3.positiveInfinity)
            {

                _cursor.transform.position = newPoint;
            }

        }

    }
}
