using UnityEngine;
using Zenject;

namespace DI
{
    [CreateAssetMenu(fileName = "TextDisplayer", menuName = "Installers/TextDisplayer")]
    public class TextDisplayer : ScriptableObjectInstaller<TextDisplayer>
    {
        public FizzBuzzService fizzBuzzService;
        public override void InstallBindings()
        {
            Container.BindInterfacesAndSelfTo<FizzBuzzService>().FromInstance(fizzBuzzService).AsSingle();
        }
    }
}