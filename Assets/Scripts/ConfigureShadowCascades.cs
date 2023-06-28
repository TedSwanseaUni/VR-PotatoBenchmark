using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

[ExecuteInEditMode]
public class ConfigureShadowCascades : MonoBehaviour
{
    public bool m_EnableCascades;

    public void Awake()
    {
        UnityEngine.Rendering.Universal.UniversalRenderPipelineAsset asset = GraphicsSettings.renderPipelineAsset as UnityEngine.Rendering.Universal.UniversalRenderPipelineAsset;
        if (asset != null)
            asset.shadowCascadeCount = (m_EnableCascades) ? 4 :0;
        QualitySettings.shadowCascades = (m_EnableCascades) ? 4 : 1;
    }
}
