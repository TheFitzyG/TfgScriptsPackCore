using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using JetBrains.Annotations;
using TFG_SP;
using UnityEngine;

namespace NoEyeInTea
{
    public class DisplayBoard : MonoBehaviour
    {

        [SerializeField] private ChoiceType _choiceType;

        [SerializeField] private int _elementsCount;

        [SerializeField] private MeshRenderer[] _renderers;

        [SerializeField] private float[] _weights;

        enum ChoiceType
        {
            RandomElement,
            RandomElements,
            WeightedSelection,
        }

        [UsedImplicitly]
        public void Choose()
        {

            foreach (var meshRenderer in _renderers)
            {
                meshRenderer.material.color = TfgColor.FromHex("FF0000");
            }

            switch (_choiceType)
            {
                case ChoiceType.RandomElement:

                    var outPut = TfgRandom.GetRandomElement(_renderers);
                    outPut.material.color = TfgColor.FromHex("A1FF0A");

                    break;

                case ChoiceType.RandomElements:

                    var elementsOut = _renderers.ToList().GetRandomValues(_elementsCount);

                    foreach (var meshRenderer in elementsOut)
                    {
                        meshRenderer.material.color = TfgColor.FromHex("A1FF0A");
                    }

                    break;

                case ChoiceType.WeightedSelection:

                    var selection = TfgRandom.GetWeightedElement(_renderers, _weights);
                    selection.material.color = TfgColor.FromHex("A1FF0A");

                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
           
        }

    }
}
