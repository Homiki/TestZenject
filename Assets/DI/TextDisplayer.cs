using UnityEngine;
using Zenject;

[CreateAssetMenu(fileName = "TextDisplayer", menuName = "Installers/TextDisplayer")]
public class TextDisplayer : ScriptableObjectInstaller<TextDisplayer>
{
    public FizzBuzz fizzBuzz;
    public override void InstallBindings()
    {
        Container.BindInterfacesAndSelfTo<FizzBuzz>().FromInstance(fizzBuzz).AsSingle();
    }
}