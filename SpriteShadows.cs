using UnityEngine;
using UnityEngine.Rendering;

namespace VFX.Sprite_Shadows
{
    [ExecuteAlways, RequireComponent(typeof(SpriteRenderer))]
    public class SpriteShadows : MonoBehaviour
    {
        public ShadowCastingMode shadowCastingMode = ShadowCastingMode.On;
        public MotionVectorGenerationMode motionVectorGenerationMode = MotionVectorGenerationMode.Object;
        public bool receiveShadows = true;
        private SpriteRenderer sr;
        //private Canvas
        private void Start()
        {
            sr = GetComponent<SpriteRenderer>();
            UpdateSpriteParameters();
        }

        [ContextMenu("Update Sprite Parameters")]
        public void UpdateSpriteParameters()
        {
            if (sr == null) return;
            sr.receiveShadows = receiveShadows;
            sr.shadowCastingMode = shadowCastingMode;
            sr.motionVectorGenerationMode = motionVectorGenerationMode;
        }
    }
}
