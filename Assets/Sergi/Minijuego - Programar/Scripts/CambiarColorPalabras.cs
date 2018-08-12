using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CambiarColorPalabras : MonoBehaviour
{
    public TextMeshProUGUI textoCambiar;

    void Awake()
    {
        textoCambiar = GetComponent<TextMeshProUGUI>();
        textoCambiar.text = "void Start ()";
        textoCambiar.ForceMeshUpdate(); // Needed to force TextMesh Pro regenerate the mesh before the end of the frame.
    }

    //    private TextMeshProUGUI m_textMeshPro;

    //    void Awake()
    //    {
    //        m_textMeshPro = GetComponent<TextMeshProUGUI>();
    //        m_textMeshPro.text = "A long time ago, in a galaxy far far away.";
    //        m_textMeshPro.ForceMeshUpdate(); // Needed to force TextMesh Pro regenerate the mesh before the end of the frame.
    //    }



    //    IEnumerator Start()
    //    {
    //        // Get reference to the textInfo class.
    //        TextInfo textInfo = m_textMeshPro.textInfo;
    //        UIVertex[] uiVertices = m_textMeshPro.mesh; // This contains the UiVertex[] (ie. the mesh). I should rename this property to avoid confusion.

    //        // Instructs TextMesh Pro not to render the text that has been laid out by it since we will be changing it.
    //        m_textMeshPro.renderMode = TextRenderFlags.DontRender;

    //        while (true)
    //        {
    //            if (m_textMeshPro.hasChanged)
    //                m_textMeshPro.ForceMeshUpdate(); // If any of the properties have changed like the text for instance, we force TextMesh Pro to regenerate the data so we can tweak it again.


    //            // Get # of Words in text object
    //            int wordCount = textInfo.wordCount;
    //            if (wordCount == 0)
    //            {
    //                yield return null;
    //                continue;
    //            }


    //            // Iterate through each word
    //            for (int i = 0; i < wordCount; i++)
    //            {
    //                // Pick a round color for each word
    //                Color32 c = new Color32((byte)Random.Range(0, 255), (byte)Random.Range(0, 255), (byte)Random.Range(0, 255), 127);

    //                WordInfo wordInfo = textInfo.wordInfo[i];

    //                // Get # of Characters for each words
    //                int charCount = wordInfo.characterCount;

    //                //string word = string.Empty;

    //                // Iterate through each character of each words
    //                for (int j = 0; j < charCount; j++)
    //                {
    //                    // Get the vertices index for the characters
    //                    int vertIndex = textInfo.characterInfo[wordInfo.firstCharacterIndex].vertexIndex;

    //                    int index_X4 = j * 4;
    //                    uiVertices[vertIndex + 0 + index_X4].color = c;
    //                    uiVertices[vertIndex + 1 + index_X4].color = c;
    //                    uiVertices[vertIndex + 2 + index_X4].color = c;
    //                    uiVertices[vertIndex + 3 + index_X4].color = c;

    //                    //word += textInfo.characterInfo[wordInfo.firstCharacterIndex + j].character;
    //                }

    //                //Debug.Log("Word # " + i + " is [" + word + "].");
    //            }

    //            // Push the modified uiVertex array to the Canvas Renderer
    //            m_textMeshPro.canvasRenderer.SetVertices(uiVertices, uiVertices.Length);

    //            yield return new WaitForSeconds(0.25f);
    //        }
    //    }
}