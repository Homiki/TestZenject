using UnityEngine;
using Zenject;

[CreateAssetMenu(fileName = "TextDisplayer", menuName = "Installers/TextDisplayer")]
public class TextDisplayer : ScriptableObjectInstaller<TextDisplayer>
{
    public override void InstallBindings()
    {
    }
}