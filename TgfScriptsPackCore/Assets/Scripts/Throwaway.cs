using System;
using System.Collections.Generic;
using TFG_SP;
using UnityEngine;

namespace NoEyeInTea
{
    public class Throwaway : MonoBehaviour
    {


        //["ff6d00","ff7900","ff8500","ff9100","ff9e00","240046","3c096c","5a189a","7b2cbf","9d4edd"]

        


        public uint v;

        private void Start()
        {

            var x = 10;
            while (x-- > 0)
            {
                Debug.Log(x);
            }

        }


        [Serializable]
        public class History<T> where T : class
        {
            private List<T> _history;

            public History()
            {
                _history = new List<T>();
            }

            public void Set(T value)
            {
                if (_history.Count > 0)
                {
                    if (_history[0] != value)
                    {
                        _history.Insert(0, value);
                    }
                }
                else
                {
                    _history.Add(value);
                }
            }

            public T Get(int index)
            {
                if (_history.Count > 0)
                {
                    var clamp = Mathf.Clamp(index, 0, _history.Count - 1);

                    return (T)_history[clamp];
                }

                return null;
            }

            public void DebugDump()
            {
                string output = "";
                for (int i = 0; i < _history.Count; i++)
                {
                    output += $"| {i}, {_history[i]} ";
                }

                Debug.Log(output);
            }
        }
    }
}
