﻿// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.

using UnityEditor;
using UnityEngine;

namespace Microsoft.MixedReality.Toolkit.Editor
{
    public static class MixedRealityStylesUtility
    {
        /// <summary>
        /// Default style for foldouts with bold title
        /// </summary>
        public static readonly GUIStyle BoldFoldoutStyle =
          new GUIStyle(EditorStyles.foldout)
          {
              fontStyle = FontStyle.Bold
          };

        /// <summary>
        /// Default style for foldouts with bold large font size title
        /// </summary>
        public static readonly GUIStyle BoldTitleFoldoutStyle =
          new GUIStyle(EditorStyles.foldout)
          {
              fontStyle = FontStyle.Bold,
              fontSize = InspectorUIUtility.TitleFontSize,
          };

        /// <summary>
        /// Default style for foldouts with large font size title
        /// </summary>
        public static readonly GUIStyle TitleFoldoutStyle =
          new GUIStyle(EditorStyles.foldout)
          {
              fontSize = InspectorUIUtility.TitleFontSize,
          };

        /// <summary>
        /// Default style for controller mapping buttons
        /// </summary>
        public static readonly GUIStyle ControllerButtonStyle = new GUIStyle("iconButton")
        {
            imagePosition = ImagePosition.ImageAbove,
            fixedHeight = 128,
            fontStyle = FontStyle.Bold,
            stretchHeight = true,
            stretchWidth = true,
            wordWrap = true,
            fontSize = 10,
            alignment = TextAnchor.UpperCenter,
            fixedWidth = 0,
            margin = new RectOffset(0, 0, 0, 0)
        };

        /// <summary>
        /// Default style for bold large font size title
        /// </summary>
        public static readonly GUIStyle BoldLargeTitleStyle = new GUIStyle(EditorStyles.boldLabel)
        {
            fontSize = InspectorUIUtility.TitleFontSize,
        };

        internal static readonly GUIStyle LicenseStyle = new GUIStyle(EditorStyles.label)
        {
            alignment = TextAnchor.MiddleCenter
        };
    }
}
