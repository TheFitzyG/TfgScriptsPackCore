using System;
using System.Collections.Generic;
using TFG_SP;
using UnityEditor;
using UnityEngine;

namespace NoEyeInTea
{

    [RequireComponent(typeof(Collider))]
    public class InteractionManager : MonoBehaviour
    {

        //[SerializeField] private Collider _triggerVolume;

        [SerializeField] private LayerMask _interactableLayers;

        private List<IInteractable> _interactables = new List<IInteractable>();

        private IInteractable _current;
        private void OnTriggerEnter(Collider other)
        {

            if (TfgChecks.CompareLayers(_interactableLayers, other.gameObject))
            {
                var interactable = other.GetComponent<IInteractable>();

                if (_interactables.Contains(interactable))
                {
                    return;
                }

                _interactables.Add(interactable);
            }
        }


        private void OnTriggerExit(Collider other)
        {

            if (TfgChecks.CompareLayers(_interactableLayers, other.gameObject))
            {
                var interactable = other.GetComponent<IInteractable>();

                if (!_interactables.Contains(interactable))
                {
                    return;
                }

                interactable.SetInactive();
                _interactables.Remove(interactable);
            }
        }


        private void Update()
        {

            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                if (_current != null)
                {
                    _current.Interact();
                }
               
            }

        }

        private void FixedUpdate()
        {

            if (_interactables.Count <= 0)
            {
                _current = null;
                return;
            }

            var nearest = GetTransformClosestToScreenCenter(_interactables); //GetNearestTransform(_interactables, transform);

            foreach (var interactable in _interactables)
            {
                if (interactable == nearest)
                {
                    continue;
                }

                interactable.SetInactive();
            }

            nearest.SetActive();

            _current = nearest;
        }


        public static IInteractable GetTransformClosestToScreenCenter(IList<IInteractable> list)
        {
            IInteractable tMin = null;
            var minDist = Mathf.Infinity;

            foreach (var interactable in list)
            {
                var dist = Camera.main.WorldToViewportPoint(interactable.GetTransform().position);

                dist.z = 0;
                dist.x -= 0.5f;
                dist.y -= 0.5f;

                if (dist.magnitude < minDist)
                {
                    minDist = dist.magnitude;
                    tMin = interactable;
                }
            }

            return tMin;
        }

        public static IInteractable GetNearestTransform(IList<IInteractable> list, Transform currentTransform)
        {
            IInteractable tMin = null;
            var minDist = Mathf.Infinity;
            var currentPos = currentTransform.position;
            foreach (var t in list)
            {
                var dist = Vector3.Distance(t.GetTransform().position, currentPos);
                if (!(dist < minDist))
                {
                    continue;
                }

                tMin = t;
                minDist = dist;
            }

            return tMin;
        }

    }
}
