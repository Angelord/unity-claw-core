﻿﻿using System.Runtime.CompilerServices;
 using Claw.Utility.Extensions;
 using UnityEngine;
using UnityEngine.UI;

namespace Claw.UserInterface.Utility {
    /// <summary> Collection of helpers related to UI Graphics.</summary>
    public static class GraphicHelpers {

        public static void SetAlpha(this Graphic graphic, float alpha) {
            
            graphic.color = graphic.color.WithAlpha(alpha);
        }
        
        public static void SetWorldSpacePosition(this Graphic graphic, Vector3 worldSpacePos) {
            
            Vector2 targetScreenPos = UnityEngine.Camera.main.WorldToScreenPoint(worldSpacePos);

            graphic.rectTransform.anchoredPosition = targetScreenPos;
        }
    }
}