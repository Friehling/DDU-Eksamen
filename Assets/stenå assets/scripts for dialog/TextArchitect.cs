using System.Collections;
using UnityEngine;
using TMPro;
using System.Security.Cryptography.X509Certificates;

public class TextArchitect 
{
    private TextMeshProUGUI tmpro_ui;
    private TextMeshPro tmpro_world;

    public TMP_Text tmpro => tmpro_ui!= null ? tmpro_ui : tmpro_world;
    public string targetText { get; private set; } = "";
    public string preText { get; private set; } = "";

    private int preTextLength =0;
    public string fullTargetText => preText + targetText;
}
