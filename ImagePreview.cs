using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
#if UNITY_EDITOR
using UnityEditor;
#endif
namespace Syy.Logics
{
    [RequireComponent(typeof(Image))]
    public class ImagePreview : MonoBehaviour
    {
    }

#if UNITY_EDITOR
    [CustomEditor(typeof(ImagePreview))]
    public class ImagePreviewEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            var imagePreview = (ImagePreview)target;
            var image = imagePreview.GetComponent<Image>();
            EditorGUILayout.ObjectField("Preview", image.sprite, typeof(Sprite), true);
        }
    }
#endif
}
