using System.Collections;
using System.Collections.Generic;
using Unity.IO.LowLevel.Unsafe;
using UnityEngine;

namespace NoEyeInTea
{
    public interface IInteractable
    {
        public abstract void Interact();

        public abstract bool CanInteractWith();

        public abstract void ResetInteraction();

        public abstract Transform GetTransform();


        public abstract void SetActive();
        public abstract void SetInactive();

    }
}
