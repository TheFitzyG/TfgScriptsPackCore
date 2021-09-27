using NoEyeInTea.InputStuff;
using UnityEditor;
using UnityEngine;

namespace NoEyeInTea.TFG_SP.Scripts.Characters.Controllers
{
    public class PCM : MonoBehaviour
    {
        public static PCM Inst;

        public BasicControls BC;
       // public UI
        private void OnEnable()
        {
            BC = new BasicControls();
            BC.Basic.Enable();
            BC.UI.Enable();

            if (Inst == null) {

                Inst = this;
            
            } else if (Inst != this)
            {
                DestroyImmediate(this);
            }

            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
            

           // PauseState.Inst.OnPause += BC.Basic.Disable;
           // PauseState.Inst.OnUnPause += BC.Basic.Enable;
        }

        private void OnDisable()
        {
            if (!Application.isPlaying)
            {
                return;
            }
            BC.Basic.Disable();
            BC.UI.Disable();

            //PauseState.Inst.OnPause -= BC.Basic.Disable;
            //PauseState.Inst.OnUnPause -= BC.Basic.Enable;
        }
    }
}
