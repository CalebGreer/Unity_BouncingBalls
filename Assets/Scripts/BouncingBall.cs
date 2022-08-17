using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BouncingBall : MonoBehaviour
{
    [SerializeField] private TextMeshPro m_text;
    [SerializeField] private Renderer m_renderer;

    [SerializeField] private Color m_purpleColor;
    [SerializeField] private Color m_blueColor;
    [SerializeField] private Color m_redColor;
    [SerializeField] private Color m_greyColor;

    public void Setup(int id)
    {
        m_text.text = id.ToString();

        if (id % 3 == 0 && id % 5 == 0)
        {
            m_renderer.material.color = m_purpleColor;
        }
        else if (id % 5 == 0)
        {
            m_renderer.material.color = m_blueColor;
        }
        else if (id % 3 == 0)
        {
            m_renderer.material.color = m_redColor;
        }
        else
        {
            m_renderer.material.color = m_greyColor;
        }
    }
}
