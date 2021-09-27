using System;
using System.Collections;
using DG.Tweening;
using DG.Tweening.Core.Easing;
using TFG_SP;
using UnityEngine;
using UnityEngine.Events;

namespace NoEyeInTea.ButtonsAndLevers
{
    public class Button : MonoBehaviour, IInteractable
    {

        [SerializeField] private GameObject _buttonFace;
        [SerializeField] private Vector3 _buttonTravel;
        [SerializeField] private float _inTime;
        [SerializeField] private float _outTime;
        [SerializeField] private Ease _easeIn;
        [SerializeField] private Ease _easeOut;
        [SerializeField] private float _sustainTime;
        [SerializeField] private bool _lockOnPress;


        [SerializeField] private EaseCurve _easeCurve;
        [SerializeField] private EaseFactory _easeFactory;

        [Space]
        [SerializeField] private UnityEvent _onPress;

        private bool _locked;

        private void PressButton()
        {
            if (_locked) { return; }

            _buttonFace.transform.DOLocalMove(_buttonTravel, _inTime).SetEase(_easeIn);

            _onPress?.Invoke();

            _locked = true;

            if (_lockOnPress)
            {
                return;
            }

            StartCoroutine(AutoReset());
        }

        private IEnumerator AutoReset()
        {
            yield return new WaitForSeconds(_inTime + _sustainTime);

            StartCoroutine(ResetButton());
        }

        private IEnumerator ResetButton()
        {
            if (!_locked) yield break;

            _buttonFace.transform.DOLocalMove(Vector3.zero, _outTime).SetEase(_easeOut);

            yield return new WaitForSeconds(_outTime);

            _locked = false;
        }

        public void Interact()
        {
            PressButton();
        }

        public bool CanInteractWith()
        {
            return !_locked;
        }

        public void ResetInteraction()
        {
            StartCoroutine(ResetButton());
        }

        public Transform GetTransform()
        {
            return transform;
        }

        public void SetActive()
        {
            //Debug.Log($"Im active {gameObject.name}");

            _buttonFace.GetComponent<MeshRenderer>().material.color = TfgColor.FromHex("A1FF0A");

        }

        public void SetInactive()
        {
            //Debug.Log($"Im inactive {gameObject.name}");

            _buttonFace.GetComponent<MeshRenderer>().material.color = TfgColor.FromHex("FF0000");
        }
    }
}
